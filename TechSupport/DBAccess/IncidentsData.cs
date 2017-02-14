using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using TechSupport.Model;
using TechSupport.Controller;

namespace TechSupport.DBAccess
{
    class IncidentsData
    {

        public static List<Incidents> DisplayOpenIncidents()
        {
 
            string select = "SELECT i.productCode, i.dateOpened, c.name AS Customer, t.name AS Technician, i.title " +
                "FROM Incidents i LEFT OUTER JOIN Customers AS c ON c.customerID = i.customerID " +
                "LEFT OUTER JOIN Technicians AS t ON t.techID = i.techID " +
                "WHERE i.dateClosed IS NULL ORDER BY i.dateOpened ASC";

            List<Incidents> openIncidentList = new List<Incidents>();

            try
            {
                using (SqlConnection connection = DBConnection.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand selectQuery = new SqlCommand(select, connection))
                    {
                        using (SqlDataReader reader = selectQuery.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Incidents incident = new Incidents();
                                incident.ProductCode = reader["productCode"].ToString();
                                incident.DateOpened = (DateTime)reader["dateOpened"];
                                incident.CustomerName = reader["Customer"].ToString();
                                incident.Technician = reader["Technician"].ToString();
                                incident.Title = reader["Title"].ToString();
                                openIncidentList.Add(incident);
                            }
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                throw e;
            }
            catch (Exception e) {
                throw e;
            }
            return openIncidentList;
        }




        public static int AddIncident(Incidents inc)
        {

            SqlConnection connect = DBConnection.GetConnection();
            string insertStatement = "INSERT INTO Incidents (CustomerID, ProductCode, DateOpened, Title, Description) VALUES (@CustomerID, @ProductCode, @DateOpened, @Title, @Description)";
            SqlCommand insertCmd = new SqlCommand(insertStatement, connect);
            insertCmd.Parameters.AddWithValue("@CustomerID", inc.CustomerID);
            insertCmd.Parameters.AddWithValue("@ProductCode", inc.ProductCode);
            insertCmd.Parameters.AddWithValue("@DateOpened", DateTime.Now);
            insertCmd.Parameters.AddWithValue("@Title", inc.Title);
            insertCmd.Parameters.AddWithValue("@Description", inc.Description);

            try
            {
                connect.Open();
                insertCmd.ExecuteNonQuery();
                string selStatement = "SELECT TOP(1) IncidentID FROM Incidents ORDER BY DateOpened DESC";
                SqlCommand selCmd = new SqlCommand(selStatement, connect);
                int incidentID = Convert.ToInt32(selCmd.ExecuteScalar());
                return incidentID;
            }
            catch (SqlException sqlex)
            {
                throw sqlex;
            }
            finally
            {
                connect.Close();
            }

        }



        public static Incidents GetIncident(int @incidentID)
        {

            Incidents inc = new Incidents();
            string selStmt = "SELECT IncidentID, Incidents.CustomerID, Customers.Name, ProductCode, DateOpened, Title, Description, TechID " + 
                "FROM Incidents INNER JOIN Customers ON Incidents.CustomerID = Customers.CustomerID WHERE IncidentID = " + @incidentID;

            try
            {

                using (SqlConnection connect = DBConnection.GetConnection())
                {

                    try
                    {

                        connect.Open();

                    }
                    catch (SqlException sqlex) { throw sqlex; }

                    using (SqlCommand selCmd = new SqlCommand(selStmt, connect))

                    using (SqlDataReader reader = selCmd.ExecuteReader())
                    {

                        int customerName = reader.GetOrdinal("Name");
                        int productCode = reader.GetOrdinal("ProductCode");
                        int dateOpened = reader.GetOrdinal("DateOpened");
                        int title = reader.GetOrdinal("Title");
                        int description = reader.GetOrdinal("Description");
                        int techID = reader.GetOrdinal("TechID");

                        while (reader.Read())
                        {

                            if (reader.IsDBNull(inc.TechID))
                            {
                                inc = null;
                            }
                            else
                            {
                                inc.TechID = (int)reader["TechID"];
                            }

                            inc.IncidentID = (int)reader["IncidentID"];
                            inc.CustomerID = (int)reader["CustomerID"];
                            inc.CustomerName = reader.GetString(customerName);
                            inc.ProductCode = reader.GetString(productCode);
                            inc.DateOpened = reader.GetDateTime(dateOpened);
                            inc.Title = reader.GetString(title);
                            inc.Description = reader.GetString(description);

                        }

                        connect.Close();

                    }

                }

            }
            catch (SqlException sqlex) { throw sqlex; }
            catch (Exception ex) { throw ex;  }

            return inc;

        }


        public static bool CloseIncident(int incidentID)
        {

            string updateStmt = "UPDATE Incidents SET DateClosed = @dc WHERE IncidentID = @incID";

            try
            {
                using (SqlConnection connect = DBConnection.GetConnection())
                {
                    connect.Open();
                    using (SqlCommand cmd = new SqlCommand(updateStmt, connect))
                    {
                        cmd.Parameters.AddWithValue("@dc", DateTime.Now);
                        cmd.Parameters.AddWithValue("@incID", incidentID);
                        int rowCount = cmd.ExecuteNonQuery();
                        return (rowCount > 0);
                    }
                }

            }
            catch (SqlException sqlex)
            {
                throw sqlex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }




    }
}
