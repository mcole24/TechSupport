using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSupport.Model;
using TechSupport.DBAccess;

namespace TechSupport.Controller
{
    class ProductsController
    {
        public ProductsController() { }

        public List<Products> GetProducts()
        {
            return ProductsData.GetProducts();
        }

    }
}
