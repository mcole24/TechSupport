using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.View
{
    public partial class ViewIncidentsByTechnicianForm : Form
    {

        private List<Technicians> techList;
        private List<Incidents> incidentList;
        private Technicians tech;
        

        public ViewIncidentsByTechnicianForm()
        {
            InitializeComponent();
        }

        private void ViewIncidentsByTechnicianForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'techSupportDataSet.Technicians' table. You can move, or remove it, as needed.
            //this.techniciansTableAdapter.Fill(this.techSupportDataSet.Technicians);
            try
            {
                this.techList = TechniciansController.GetTechniciansWithIncidents();
                techComboBox.DataSource = techList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                this.BeginInvoke(new MethodInvoker(Close));
            }         
        }

        /*
        private void GetTechniciansWithIncidents()
        {
            try
            {
                this.techList = TechniciansController.GetTechniciansWithIncidents();
                techComboBox.DataSource = techList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
        */

            /*
        private void GetTechInfo()
        {
            int techID = (int)techComboBox.SelectedValue;
            try
            {
                this.tech = TechniciansController.GetTechInfo(techID);
                //this.tech = this.techList[techComboBox.SelectedIndex];
                techniciansBindingSource.Clear();
                techniciansBindingSource.Add(this.tech);
                this.incidentList = IncidentsController.GetIncidentsByTechnician(techID);
                //incidentsDataGridView.DataSource = this.incidentList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
        */

        private void techComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (techComboBox.SelectedIndex < 0)
                {
                    return;
                }
                this.tech = techList[techComboBox.SelectedIndex];
                techniciansBindingSource.Clear();
                techniciansBindingSource.Add(this.tech);
                //this.incidentList = IncidentsController.GetIncidentsByTechnician(this.tech.TechID);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                this.BeginInvoke(new MethodInvoker(Close));
            }
        }

        
    }
}
