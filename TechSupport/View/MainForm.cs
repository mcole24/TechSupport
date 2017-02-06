using System;
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void createIncidentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (SqlException excp)
            {
                MessageBox.Show(excp.Message, excp.GetType().ToString());
            }
        }
    }
}
