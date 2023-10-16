using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DataAccess
    {
        public static SqlConnection connection;

        public static SqlConnection Connection
        {
            get
            {
                if (connection == null) 
                {
                    connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True");
                }
                else if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                return connection;
            }

        } //Opens connection if it is not open
        public static DataSet GetDataSet(string query) //Returns DataSet from query
        {
            SqlCommand cmd = new SqlCommand(query, Connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public static SqlDataReader GetDataReader(string query) //Returns DataReader from query
        {
            SqlCommand cmd = new SqlCommand(query, Connection);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
        public static bool HasValue(string query) //Returns true if data is in the database
        {
            SqlCommand sqcom = new SqlCommand(query, Connection);
            SqlDataReader dr = sqcom.ExecuteReader();
            if (dr.Read())
            {
                dr.Close();
                return true;
            }
            dr.Close();
            return false;
        }
        public static DataTable GetDataTable(string query) //Returns DataTable from query
        {
            var ds = GetDataSet(query);
            if (ds.Tables.Count > 0)
            {
                return ds.Tables[0];
            }
            return null;
        }

        public static int ExecuteQuery(string query)  //ExecutesNonQuery from query
        {
            SqlCommand cmd = new SqlCommand(query, Connection);
            return cmd.ExecuteNonQuery();
        }
        public static void CloseConnection() //Closes connection
        {
            if(connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
        }
        public static string GetDataBaseName() //Gets database name
        {

            string db = connection.Database.ToString();
            return db;
        }

    }
}
