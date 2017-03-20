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
            this.incidentsTableAdapter.Fill(this.techSupportDataSet.Incidents);
            this.reportViewer1.RefreshReport();
        }
    }
}
