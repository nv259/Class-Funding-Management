using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTO
{
    public class Account
    {
        private int mssv, role;
        private string display_name, password;

        public int Mssv { get { return mssv; } set { mssv = value; } }
        public int Role { get { return role; } set { role = value; } }
        public string DisplayName { get { return display_name; } set { display_name = value; } }
        public string Password { get { return password; } set { password = value; } }
    }
}
