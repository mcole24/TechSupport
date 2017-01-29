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

        public static List<Incidents> DisplayOpenIncidents() {
 
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

    }
}
