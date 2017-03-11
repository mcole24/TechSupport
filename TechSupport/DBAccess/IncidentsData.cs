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
            string selStmt = "SELECT IncidentID, Incidents.CustomerID, Customers.Name AS CustomerName, Incidents.ProductCode AS IncProductCode, Products.Name AS ProductName, DateOpened, DateClosed, Title, Description, TechID " +
                "FROM Incidents INNER JOIN Customers ON Incidents.CustomerID = Customers.CustomerID INNER JOIN Products ON Incidents.ProductCode = Products.ProductCode WHERE IncidentID = " + @incidentID;

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
                        
                        if (reader.Read())
                        {


                            if (reader["DateClosed"] != DBNull.Value)
                            {
                                inc.DateClosed = (DateTime)reader["DateClosed"];
                            }


                            inc.CustomerID = (int)reader["CustomerID"];
                            inc.CustomerName = reader["CustomerName"].ToString();
                            inc.ProductCode = reader["IncProductCode"].ToString();
                            inc.ProductName = reader["ProductName"].ToString();
                            inc.DateOpened = (DateTime)reader["DateOpened"];
                            inc.Title = reader["Title"].ToString();
                            inc.Description = reader["Description"].ToString();

                            if (reader["TechID"] != DBNull.Value)
                            {
                                inc.TechID = (int)reader["TechID"];
                            }
                            

                            if (reader["IncidentID"] == DBNull.Value)
                            {
                                inc = null;
                            }
                            else
                            {
                                inc.IncidentID = (int)reader["IncidentID"];
                            }

                        }
                        else
                        {
                            inc = null;
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
                        return (cmd.ExecuteNonQuery() > 0);
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


        public static bool UpdateIncident(Incidents oldInc, Incidents newInc)
        {
            string updateStmt = "UPDATE Incidents SET TechID = @newTech, Description = @newDesc WHERE IncidentID = @oldIncID";

            try
            {
                using (SqlConnection connect = DBConnection.GetConnection())
                {
                    connect.Open();
                    using (SqlCommand cmd = new SqlCommand(updateStmt, connect))
                    {
                        
                        if (newInc.TechID == int.MinValue)
                        {
                            cmd.Parameters.AddWithValue("@newTech", DBNull.Value);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@newTech", newInc.TechID);
                        }
              
                        cmd.Parameters.AddWithValue("@oldDesc", oldInc.Description);
                        cmd.Parameters.AddWithValue("@oldIncID", oldInc.IncidentID);
                        cmd.Parameters.AddWithValue("@newDesc", newInc.Description);
                        return (cmd.ExecuteNonQuery() > 0);
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




        public static List<Incidents> GetIncidentsByTechnician(int TechID)
        {
            List<Incidents> incidentList = new List<Incidents>();
            string selectStmt = "SELECT i.TechID, p.Name AS [Product], i.DateOpened, c.Name AS [Customer], i.Title " + 
                "FROM Incidents i INNER JOIN Products p ON i.ProductCode = p.ProductCode " + 
                "INNER JOIN Customers c ON i.CustomerID = c.CustomerID";
            try
            {
                using (SqlConnection connect = DBConnection.GetConnection())
                {
                    connect.Open();
                    using (SqlCommand cmd = new SqlCommand(selectStmt, connect))
                    {
                        cmd.Parameters.AddWithValue("@techID", TechID);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Incidents inc = new Incidents();
                                inc.ProductName = reader["Product"].ToString();
                                inc.DateOpened = (DateTime)reader["DateOpened"];
                                inc.CustomerName = reader["Customer"].ToString();
                                inc.Title = reader["Title"].ToString();
                                incidentList.Add(inc);
                            }
                        }
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
            return incidentList;
        }




    }
}
