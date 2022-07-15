using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class DataProvider
    {
        private string strCon = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Management;Integrated Security=True";
        private static DataProvider instance;
        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return instance; }
        }

        public DataTable ExecuteQuery(string query, object[] parameters = null)
        {
            DataTable dt = new DataTable();
            using (SqlConnection sqlcon = new SqlConnection(strCon))
            {
                sqlcon.Open();

                SqlCommand cmd = new SqlCommand(query, sqlcon);
                if (parameters != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                            cmd.Parameters.AddWithValue(item, parameters[i++]);
                    }
                }

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                sqlcon.Close();
            }

            return dt;
        }

        public int ExecuteNonQuery(string query, object[] parameters = null)
        {
            int row_affect = 0;

            using (SqlConnection sqlcon = new SqlConnection(strCon))
            {
                sqlcon.Open();

                SqlCommand cmd = new SqlCommand(query, sqlcon);
                if (parameters != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                            cmd.Parameters.AddWithValue(item, parameters[i++]);
                    }
                }
                row_affect = cmd.ExecuteNonQuery();

                sqlcon.Close();
            }

            return row_affect;
        }
    }
}
