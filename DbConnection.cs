using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace KHADPULE_NATI
{ 
    public class DbConnection
    {
        public static SqlConnection GetConnection()
        {
            var conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-0E4S1DT;Initial Catalog=KHADPULE_NS;Integrated Security=True";
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            return conn;
        }
    }
}