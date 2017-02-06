using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSupport.Model;
using System.Data.SqlClient;

namespace TechSupport.DBAccess
{
    public static class CustomersData
    {

        public static List<Customers> GetCustomers()
        {
            List<Customers> customerList = new List<Customers>();
            string selStatement = "SELECT Name, CustomerID FROM Customers ORDER BY CustomerID";
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
                        int nameOrder = reader.GetOrdinal("Name");
                        while (reader.Read())
                        {
                            Customers customer = new Customers();
                            customer.Name = reader.GetString(nameOrder);
                            customer.CustomerID = (int)reader["CustomerID"];
                            customerList.Add(customer);
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
            return customerList;
        }

    }
}
