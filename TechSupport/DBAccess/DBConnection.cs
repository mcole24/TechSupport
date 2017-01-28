using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TechSupport.DBAccess {

    //Sets up the database connection
    class DBConnection {

        public static SqlConnection GetConnection() {
            try
            {
                string connectionString = "Data Source=localhost;Initial Catalog=TechSupport;Integrated Security=True;";
                SqlConnection connection = new SqlConnection(connectionString);
                return connection;
            }
            catch (SqlException exception) {
                throw exception;
            }
        }

    }
}
