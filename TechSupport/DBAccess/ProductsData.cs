using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSupport.Model;
using System.Data.SqlClient;

namespace TechSupport.DBAccess
{
    public static class ProductsData
    {

        public static List<Products> GetProducts()
        {
            List<Products> productList = new List<Products>();
            string selStatement = "SELECT ProductCode, Name FROM Products ORDER BY ProductCode";
            try
            {
                using (SqlConnection connect = DBConnection.GetConnection())
                {
                    try
                    {
                        connect.Open();
                    }
                    catch (SqlException e)
                    {
                        throw e;
                    }

                    using (SqlCommand selCmd = new SqlCommand(selStatement, connect))
                    using (SqlDataReader reader = selCmd.ExecuteReader())
                    {
                        int productOrder = reader.GetOrdinal("ProductCode");
                        while (reader.Read())
                        {
                            Products product = new Products();
                            product.ProductCode = reader.GetString(productOrder);
                            product.ProductName = (string)reader["Name"];
                            productList.Add(product);
                        }
                        connect.Close();
                    }

                }
            }
            catch (SqlException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
            return productList;
        }

    }
}
