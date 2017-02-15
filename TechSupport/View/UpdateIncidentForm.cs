using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechSupport.Model;
using TechSupport.Controller;
using TechSupport.DBAccess;
using System.Data.SqlClient;

namespace TechSupport.View
{
    public partial class UpdateIncidentForm : Form
    {

        private Incidents incident;
        private List<Technicians> technicians;


        public UpdateIncidentForm()
        {
            InitializeComponent();
            this.incident = new Incidents();
        }

        private void UpdateIncidentForm_Load(object sender, EventArgs e)
        {
            updateButton.Enabled = false;
            closeButton.Enabled = false;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void getIncidentButton_Click(object sender, EventArgs e)
        {
            int incidentID;
            try
            {
                incidentID = Convert.ToInt32(incidentIDBox.Text);
                this.GetIncident(incidentID);
            }
            catch (System.FormatException fex)
            {
                MessageBox.Show("Please input whole numbers only for the Incident ID.");
                incidentIDBox.Text = "";
                return;
            }
        
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            Incidents newInc = new Incidents();
            newInc.IncidentID = incident.IncidentID;
            if (textToAddBox.Text == "")
            {
                newInc.Description = DateTime.Now.ToString() + " Technician has been updated/assigned.";
            }
            else
            {
                newInc.Description = incident.Description + "\n" + DateTime.Now.ToString() + "\nEDIT:\n" + textToAddBox.Text;
            }
            newInc.TechID = (int)technicianComboBox.SelectedValue;

            try
            {
                bool isUpdated = IncidentsController.UpdateIncident(incident, newInc);
                if (isUpdated)
                {
                    MessageBox.Show("Incident has been updated.");
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("There was an error when attempting to update the incident.");
                    ClearFields();
                }
            }
            catch (SqlException sqlex)
            {
                MessageBox.Show(sqlex.Message, sqlex.GetType().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            if (incident.TechID > 0)
            {
                if (this.ConfirmClose())
                {
                    try
                    {
                        bool isClosed = IncidentsController.CloseIncident(incident.IncidentID);
                        if (isClosed)
                        {
                            MessageBox.Show("Incident has been closed.");
                            this.ClearFields();
                        }
                        else
                        {
                            MessageBox.Show("The incident could not be closed at ths time");
                            this.ClearFields();
                        }

                    }
                    catch (SqlException sqlex)
                    {
                        MessageBox.Show(sqlex.Message, sqlex.GetType().ToString());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("An incident must have a technician assigned before it can be closed.");
            }
        }

        private void ClearFields()
        {

            var fields = this.Controls.OfType<TextBox>().AsEnumerable<TextBox>();
            foreach (TextBox box in fields)
            {
                box.Text = "";
            }
            this.technicianComboBox.SelectedIndex = -1;
        }

        private bool ConfirmClose()
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult answer;
            string prompt = "If you close this incident, you will no longer be able to update it. Are you sure you wish to proceed?";
            answer = MessageBox.Show(prompt, "Please confirm that you wish to close.", buttons);
            return (answer == DialogResult.Yes);
        }

        private void GetIncident(int incidentID)
        {
            
            try
            {
                this.incident = IncidentsController.GetIncident(incidentID);
            }
            catch (SqlException sqlex)
            {
                MessageBox.Show("Error retrieving incident. \n" + sqlex.Message);
                return;
            }

            if (this.incident == null)
            {
                MessageBox.Show("No incident could be found with this ID: " + incidentID);
                return;
            }
            else if (this.incident.DateClosed != DateTime.MinValue)
            {
                MessageBox.Show("Incident has been closed already.");
                return;
            }
            else
            {
                this.DisplayIncident();
            }

        }


        private void DisplayIncident()
        {
            this.LoadTechnicians();

            try
            {
                technicianComboBox.SelectedValue = incident.TechID;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            technicianComboBox.Enabled = true;
            customerBox.Text = incident.CustomerName;
            productBox.Text = incident.ProductName;
            titleBox.Text = incident.Title;
            dateOpenedBox.Text = incident.DateOpened.ToString();
            descriptionBox.Text = incident.Description;
            textToAddBox.Enabled = true;
            textToAddBox.ReadOnly = false;
            updateButton.Enabled = true;
            closeButton.Enabled = true;

        }

        private void LoadTechnicians()
        {
            try
            {
                this.technicians = TechniciansController.GetTechnicians();
                technicianComboBox.DataSource = this.technicians;
                technicianComboBox.DisplayMember = "Name";
                technicianComboBox.ValueMember = "TechID";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.GetType().ToString());
            }
        }


        


    }
}
