using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.DTO;

namespace DataAccess.DAO
{ 
    public class PersonDAO
    {
        private Person userInfo;
        private static PersonDAO instance;
        public static PersonDAO Instance
        {
            get { if (instance == null) instance = new PersonDAO();  return instance; }
        }

        public Person GetUserInfoByMSSV(int mssv)
        {
            string query = "SELECT * FROM dbo.Person WHERE MSSV = @mssv ";
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.ExecuteQuery(query, new object[] { mssv });

            query = "SELECT April, May, June, July, charge, sum_money, time FROM dbo.MonthlyFunding " +
                    "LEFT JOIN dbo.SpecialFunding ON MonthlyFunding.MSSV = SpecialFunding.MSSV " +
                    "WHERE MonthlyFunding.MSSV = @mssv ";
            DataTable dt1 = new DataTable();
            dt1 = DataProvider.Instance.ExecuteQuery(query, new object[] { mssv });

            foreach (DataRow dr in dt.Rows)
            {
                foreach (DataRow dr2 in dt1.Rows)
                    return new Person(dr, dr2);
                return new Person(dr);
            }

            return null;
        }
    }
}
