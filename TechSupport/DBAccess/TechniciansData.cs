using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSupport.Model;
using System.Data.SqlClient;

namespace TechSupport.DBAccess
{
    public static class TechniciansData
    {

        public static List<Technicians> GetTechnicians()
        {
            List<Technicians> technicianList = new List<Technicians>();
            string selStatement = "SELECT TechID, Name, Email, Phone FROM Technicians ORDER BY Name";
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
                        int techOrder = reader.GetOrdinal("Name");
                        while (reader.Read())
                        {
                            Technicians tech = new Technicians();
                            tech.TechID = (int)reader["TechID"];
                            tech.Name = reader.GetString(techOrder);
                            tech.Email = (string)reader["Email"];
                            tech.Phone = (string)reader["Phone"];
                            technicianList.Add(tech);
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
            return technicianList;
        }

    }
}
