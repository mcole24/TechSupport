﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechSupport.View
{
    public partial class OpenIncidentsReport : Form
    {
        public OpenIncidentsReport()
        {
            InitializeComponent();
        }

        private void OpenIncidentsReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'techSupportDataSet.Incidents' table. You can move, or remove it, as needed.
            this.incidentsTableAdapter.Fill(this.techSupportDataSet.Incidents);
            //this.technicianIncidentsTableAdapter.Fill(this.incidentReportDataSet.TechnicianIncidents);
            //this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
