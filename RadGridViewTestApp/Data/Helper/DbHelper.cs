using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.DirectoryServices.ActiveDirectory;

namespace RadGridViewTestApp.Data.Helper
{
    public class DbHelper : ConnectionString
    {
        public SqlConnection connection;
        public DbHelper()
        {
            connection = new SqlConnection(connectionString);
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public DataSet GetDataset(string storeProcedure, SqlParameter[] parameters = null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = storeProcedure;
            cmd.CommandType = CommandType.StoredProcedure;  
            cmd.Parameters.AddRange(parameters);
            cmd.Connection = connection;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds;
        }
        public int ExecuteQuery(string storeProcedure, SqlParameter[] parameters = null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = storeProcedure;
            cmd.CommandType= CommandType.StoredProcedure;
            cmd.Parameters.AddRange(parameters);
            cmd.Connection = connection;
            return Convert.ToInt32(cmd.ExecuteScalar());
        }
    }
}
