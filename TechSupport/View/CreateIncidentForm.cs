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
using System.Data.SqlClient;

namespace TechSupport.View
{
    public partial class CreateIncidentForm : Form
    {

        private CustomersController cControl;
        private ProductsController pControl;
        private TechniciansController tControl;

        public CreateIncidentForm()
        {
            InitializeComponent();
            cControl = new CustomersController();
            pControl = new ProductsController();
            tControl = new TechniciansController();
        }

        private void createIncidentButton_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

        }

        private void CreateIncidentForm_Load(object sender, EventArgs e)
        {
            try
            {
                customerNameBox.DataSource = this.cControl.GetCustomers();
                customerNameBox.DisplayMember = "Name";
                customerNameBox.ValueMember = "CustomerID";
                customerNameBox.SelectedIndex = -1;
                productNameBox.DataSource = this.pControl.GetProducts();
                productNameBox.DisplayMember = "ProductCode";
                productNameBox.ValueMember = "ProductCode";
                productNameBox.SelectedIndex = -1;
            }
            catch (SqlException sqlex)
            {
                MessageBox.Show(sqlex.Message, sqlex.GetType().ToString());
                this.BeginInvoke(new MethodInvoker(Close));
            }
        }
    }
}
