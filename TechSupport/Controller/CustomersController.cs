using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSupport.Model;
using TechSupport.DBAccess;

namespace TechSupport.Controller
{
    class CustomersController
    {
        public CustomersController() { }

        public List<Customers> GetCustomers()
        {
            return CustomersData.GetCustomers();
        }

    }
}
