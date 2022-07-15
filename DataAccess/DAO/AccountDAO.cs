using DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class AccountDAO
    {
        private Account acc;
        private AccountDAO instance;

        public AccountDAO Instance { get { if (instance == null) instance = new AccountDAO(); return instance; } }

        public void GetAccountByUserName(string name)
        {
            string query = "SELECT * FROM ";
        }
    }
}
