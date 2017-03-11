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





        public static List<Technicians> GetTechniciansWithIncidents()
        {
            List<Technicians> technicianList = new List<Technicians>();
            string selStatement = "SELECT TechID, Name, Email, Phone FROM Technicians WHERE TechID = (SELECT DISTINCT TechID FROM Incidents )" + 
                "WHERE Technicians.TechID = Incidents.TechID AND DateClosed IS NULL) ORDER BY Name";
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




        public static Technicians GetTechInfo(int techID)
        {
            Technicians tech = new Technicians();
            string selectStmt = "SELECT TechID, Name, Email, Phone FROM Technicians WHERE TechID = @techID";
            try
            {
                using (SqlConnection connect = DBConnection.GetConnection())
                {
                    connect.Open();
                    using (SqlCommand cmd = new SqlCommand(selectStmt, connect))
                    {
                        cmd.Parameters.AddWithValue("@techID", techID);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                tech.Name = reader["Name"].ToString();
                                tech.TechID = (int)reader["TechID"];
                                tech.Email = reader["Email"].ToString();
                                tech.Phone = reader["Phone"].ToString();
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
            return tech;
        }



        private static Technicians GetTechIncidentInfo()



    }
}
