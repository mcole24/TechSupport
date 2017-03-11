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
            this.GetTechniciansWithIncidents();
            
        }


        private void GetTechniciansWithIncidents()
        {
            try
            {
                techList = TechniciansController.GetTechniciansWithIncidents();
                techComboBox.DataSource = techList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }


        private void GetIncidents()
        {
            try
            {
                int techID = (int)techComboBox.SelectedValue;
                this.tech = TechniciansController.
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }



    }
}
