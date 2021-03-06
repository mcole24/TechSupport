﻿using System;
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
using System.Data.SqlClient;

namespace TechSupport.View
{
    public partial class OpenIncidentsForm : Form
    {
        private IncidentsController iController;
        public OpenIncidentsForm()
        {
            InitializeComponent();
            iController = new IncidentsController();
        }

        

        private void OpenIncidentsForm_Load(object sender, EventArgs e)
        {
            openIncidentsListView.Items.Clear();
            List<Incidents> incidentList;

            try
            {
                incidentList = iController.DisplayOpenIncidents();
                if (incidentList.Count > 0)
                {
                    Incidents incident;
                    for (int item = 0; item < incidentList.Count; item++)
                    {
                        incident = incidentList[item];
                        openIncidentsListView.Items.Add(incident.ProductCode);
                        openIncidentsListView.Items[item].SubItems.Add(incident.DateOpened.ToShortDateString());
                        openIncidentsListView.Items[item].SubItems.Add(incident.CustomerName);
                        openIncidentsListView.Items[item].SubItems.Add(incident.Technician);
                        openIncidentsListView.Items[item].SubItems.Add(incident.Title);
                    }
                }
                else
                {
                    MessageBox.Show("No open incidents were found.");
                    this.Close();
                }
            }
            catch (SqlException excep) {
                MessageBox.Show(excep.Message, excep.GetType().ToString());
                this.BeginInvoke(new MethodInvoker(Close));
            }

        }
    }
}
