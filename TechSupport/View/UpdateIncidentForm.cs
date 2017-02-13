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
        public UpdateIncidentForm()
        {
            InitializeComponent();
        }

        private void UpdateIncidentForm_Load(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void getIncidentButton_Click(object sender, EventArgs e)
        {
            this.GetIncident();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {

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

        private Boolean ConfirmClose()
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult answer;
            string prompt = "If you close this incident, you will no longer be able to update it. Are you sure you wish to proceed?";
            answer = MessageBox.Show(prompt, "Please confirm that you wish to close.", buttons);
            return (answer == DialogResult.Yes);
        }

        private void GetIncident()
        {
            int incidentID;
            Incidents incident;
            try
            {
                incidentID = Convert.ToInt32(incidentIDBox.Text);
            }
            catch (System.FormatException fex)
            {
                MessageBox.Show("Please input whole numbers only for the Incident ID.");
                incidentIDBox.Text = "";
                return;
            }

            try
            {
                incident = IncidentsController.GetIncident(incidentID);
            }
            catch (SqlException sqlex)
            {
                MessageBox.Show("Error retrieving incident. \n" + sqlex.Message);
                return;
            }

            if (incident == null)
            {
                MessageBox.Show("No incident could be found with this ID: " + incidentID);
                return;
            }
            else if (incident.DateClosed != null)
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

        }

        private void LoadTechnicians()
        {
            try
            {
                List<Technicians> technicians = TechniciansController.GetTechnicians();
                technicianComboBox.DataSource = technicians;
                technicianComboBox.DisplayMember = "Technicians";
                technicianComboBox.ValueMember = "TechID";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.GetType().ToString());
            }
        }



    }
}
