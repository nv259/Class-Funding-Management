using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTO
{
    public class Account
    {
        public Account(DataRow dr)
        {
            mssv = (int)dr["MSSV"];
            display_name = dr["display_name"].ToString();
            password = dr["password"].ToString();
            role = dr["role"].ToString();
        }

        private int mssv;
        private string role, display_name, password;

        public int Mssv { get { return mssv; } set { mssv = value; } }
        public string Role { get { return role; } set { role = value; } }
        public string DisplayName { get { return display_name; } set { display_name = value; } }
        public string Password { get { return password; } set { password = value; } }
    }
}
