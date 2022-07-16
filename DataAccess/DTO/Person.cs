using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTO
{
    public class Person
    {
        private const string V = "";

        public Person(DataRow dr, DataRow row)
        {
            first_name = dr["first_name"].ToString();
            last_name = dr["last_name"].ToString();
            email = dr["email"].ToString();
            phone_number = dr["phone_number"].ToString();
            mssv = (int)dr["MSSV"];

            funds.April = (row["April"] != null && (bool)row["April"]) ? 1 : 0;
            funds.May = (row["May"] != null && (bool)row["May"]) ? 1 : 0;
            funds.June = (row["June"] != null && (bool)row["June"]) ? 1 : 0;
            funds.July = (row["July"] != null && (bool)row["July"]) ? 1 : 0;
            funds.Charge = (int)row["charge"];
            funds.Sum_money = (row["sum_money"] != DBNull.Value) ? Convert.ToSingle(row["sum_money"]) : 0;
            //funds.Time = (row["time"] != null) ? (DateTime)row["time"] : new DateTime(0, 0, 0);
        }

        public Person(DataRow dr)
        {
            first_name = dr["first_name"].ToString();
            last_name = dr["last_name"].ToString();
            email = dr["email"].ToString();
            phone_number = dr["phone_number"].ToString();
            mssv = (int)dr["MSSV"];
        }

        private string first_name, last_name, email, phone_number;
        private int mssv;
        private Funds funds = new Funds();

        public string FirstName { get { return first_name; } set { first_name = value; } }
        public string LastName { get { return last_name; } set { last_name = value; } }
        public string Email { get { return email; } set { email = value; } }
        public int Mssv { get { return mssv; } set { mssv = value; } }
        public string PhoneNumber { get { return phone_number; } set { phone_number = value; } }
        public Funds Funds { get { return funds; } set { funds = value; } }
    }
}
