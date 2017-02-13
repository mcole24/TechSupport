using System;
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

        }

        private void updateButton_Click(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {

        }

        private void ClearFields()
        {
            

        }

        private Boolean ConfirmClose()
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult answer;
            string prompt = "If you close this incident, you will no longer be able to update it. Are you sure you wish to proceed?";
            answer = MessageBox.Show(prompt, "Please confirm that you wish to close.", buttons);
            return (answer == DialogResult.Yes);
        }

    }
}
