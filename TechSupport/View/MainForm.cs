﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechSupport.View;
using System.Data.SqlClient;

namespace TechSupport
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        OpenIncidentsForm oif;
        CreateIncidentForm cif;
        UpdateIncidentForm uif;
        ViewIncidentsByTechnicianForm vbt;
        OpenIncidentsReport oir;

        private void displayOpenIncidentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (oif == null)
            {
                oif = new OpenIncidentsForm();
                oif.MdiParent = this;
                oif.FormClosed += oif_FormClosed;
                oif.Show();
            }
            else {
                oif.Activate();
            }
        }

        private void oif_FormClosed(object sender, FormClosedEventArgs e)
        {
            oif = null;
        }

        private void cif_FormClosed(object sender, FormClosedEventArgs e)
        {
            cif = null;
        }

        private void uif_FormClosed(object sender, FormClosedEventArgs e)
        {
            uif = null;
        }

        private void vbt_FormClosed(object sender, FormClosedEventArgs e)
        {
            vbt = null;
        }

        private void oir_FormClosed(object sender, FormClosedEventArgs e)
        {
            oir = null;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void createIncidentToolStripMenuItem_Click(object sender, EventArgs e)
        {  

            if (cif == null)
            {
                cif = new View.CreateIncidentForm();
                cif.MdiParent = this;
                cif.FormClosed += new FormClosedEventHandler(cif_FormClosed);
                cif.Show();
            }
            else cif.Activate();
            
        }

        private void updateIncidentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (uif == null)
            {
                uif = new View.UpdateIncidentForm();
                uif.MdiParent = this;
                uif.FormClosed += new FormClosedEventHandler(uif_FormClosed);
                uif.Show();
            }
            else uif.Activate();
        }

        private void viewIncidentsByTechniciansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (vbt == null)
            {
                vbt = new View.ViewIncidentsByTechnicianForm();
                vbt.MdiParent = this;
                vbt.FormClosed += new FormClosedEventHandler(vbt_FormClosed);
                vbt.Show();
            }
            else vbt.Activate();
        }

        private void openIncidentsReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (oir == null)
            {
                oir = new View.OpenIncidentsReport();
                oir.MdiParent = this;
                oir.FormClosed += new FormClosedEventHandler(oir_FormClosed);
                oir.Show();
            }
            else oir.Activate();
        }
    }
}
