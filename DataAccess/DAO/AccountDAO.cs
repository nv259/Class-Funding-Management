using DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class AccountDAO
    {
        private Account acc;
        private static AccountDAO instance;

        public static AccountDAO Instance { get { if (instance == null) instance = new AccountDAO(); return instance; } }

        public Account GetAccountByUserName(string name)
        {
            string query = "SELECT * FROM dbo.Account WHERE display_name = @name ";
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.ExecuteQuery(query, new object[] { name });
            
            foreach (DataRow dr in dt.Rows)
            {
                return new Account(dr);
            }

            return null;
        }
    }
}
