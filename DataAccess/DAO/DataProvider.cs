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

        public object ExecuteScalar(string query, object[] parameters = null)
        {
            object cell = new object();

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
                cell = cmd.ExecuteScalar();

                sqlcon.Close();
            }

            return cell;
        }

        private static readonly string[] VietNamChar = new string[]
        {
            "aAeEoOuUiIdDyY",
            "áàạảãâấầậẩẫăắằặẳẵ",
            "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ",
            "éèẹẻẽêếềệểễ",
            "ÉÈẸẺẼÊẾỀỆỂỄ",
            "óòọỏõôốồộổỗơớờợởỡ",
            "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ",
            "úùụủũưứừựửữ",
            "ÚÙỤỦŨƯỨỪỰỬỮ",
            "íìịỉĩ",
            "ÍÌỊỈĨ",
            "đ",
            "Đ",
            "ýỳỵỷỹ",
            "ÝỲỴỶỸ"
        };
        public static string LocDau(string str)
        {
            //Thay thế và lọc dấu từng char      
            for (int i = 1; i < VietNamChar.Length; i++)
            {
                for (int j = 0; j < VietNamChar[i].Length; j++)
                    str = str.Replace(VietNamChar[i][j], VietNamChar[0][i - 1]);
            }
            return str;
        }
    }
}
