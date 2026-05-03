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
        public static DataTable GetTableByQuery(string Sqlquery)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = GetConnection();
                command.CommandText = Sqlquery;
                command.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}