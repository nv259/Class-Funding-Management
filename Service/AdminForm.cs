using DataAccess.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service
{
    public partial class AdminForm : Form
    {
        private BindingSource userList = new BindingSource();
        public AdminForm()
        {
            MonthlyUpdate();
            InitializeComponent();
            user_dtgv.DataSource = userList;
            Add_Binding();
            Load_dtgv();
        }

        private void Add_Binding()
        {
            userName_txtBox.DataBindings.Add("Text", user_dtgv.DataSource, "display_name");
            mssv_txtBox.DataBindings.Add("Text", user_dtgv.DataSource, "MSSV");
            fName_txtBox.DataBindings.Add("Text", user_dtgv.DataSource, "first_name");
            lName_txtBox.DataBindings.Add("Text", user_dtgv.DataSource, "last_name");
            phone_txtBox.DataBindings.Add("Text", user_dtgv.DataSource, "phone_number");
            email_txtBox.DataBindings.Add("Text", user_dtgv.DataSource, "email");
            userRole_comboBox.DataBindings.Add("Text", user_dtgv.DataSource, "role");
        }

        private void Load_dtgv()
        {
            string query = "SELECT Account.MSSV, Account.display_name, Account.role, Person.first_name, Person.last_name, Person.email, Person.phone_number INTO TempTable FROM [dbo].[Person] " +
                           "FULL JOIN [dbo].[Account] ON Person.MSSV = Account.MSSV " +
                           "WHERE dbo.fuConvertToUnsign1(first_name) like " + "'%" + DataProvider.LocDau(this.searchTxtBox.Text) + "%' " +
                           "SELECT * FROM TempTable " +
                           "DROP TABLE TempTable";
            userList.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            string query = "SELECT Account.MSSV, Account.display_name, Account.role, Person.first_name, Person.last_name, Person.email, Person.phone_number INTO TempTable FROM [dbo].[Person] " +
                           "FULL JOIN [dbo].[Account] ON Person.MSSV = Account.MSSV " +
                           "WHERE dbo.fuConvertToUnsign1(first_name) like " + "'%" + DataProvider.LocDau(this.searchTxtBox.Text) + "%' " +
                           "SELECT * FROM TempTable " +
                           "DROP TABLE TempTable";

            userList.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            string query = "UPDATE dbo.Account SET password = N'17739242239201861993414619121120323326112' WHERE MSSV = @mssv ";
            int i = DataProvider.Instance.ExecuteNonQuery(query, new object[] { mssv_txtBox.Text });
            MessageBox.Show("Reset password successfully!");
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string query = "UPDATE dbo.Account SET role = @role WHERE MSSV = @mssv ";
            int i = DataProvider.Instance.ExecuteNonQuery(query, new object[] { this.userRole_comboBox.Text, int.Parse(this.mssv_txtBox.Text) });
            MessageBox.Show("User role is updated successfully!");
            Load_dtgv();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM dbo.Account WHERE MSSV = @mssv ";
            int i = DataProvider.Instance.ExecuteNonQuery(query, new object[] { int.Parse(this.mssv_txtBox.Text) });
            MessageBox.Show("User deleted!");
            Load_dtgv();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int mssv = int.Parse(this.mssv_txtBox.Text);
                string display_name = this.userName_txtBox.Text;

                string query = "IF NOT EXISTS (SELECT * FROM dbo.MonthlyFunding WHERE MSSV = @mssv1 ) " +
                                "BEGIN " +
                                    "INSERT INTO dbo.MonthlyFunding (MSSV) VALUES ( @mssv2 ) " +
                                "END ";
                int i = DataProvider.Instance.ExecuteNonQuery(query, new object[] { mssv, mssv });

                // Account
                query = "INSERT INTO dbo.Account VALUES ( @mssv , @name , @pwd , @role ) ";
                i = DataProvider.Instance.ExecuteNonQuery(query, new object[] { mssv, display_name, "17739242239201861993414619121120323326112", this.userRole_comboBox.Text });

                // Person
                query = "INSERT INTO dbo.Person (MSSV) VALUES ( @mssv ) ";
                i = DataProvider.Instance.ExecuteNonQuery(query, new object[] { mssv });

                MessageBox.Show("A new user is added Successfully!");
                Load_dtgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show("User is already exist!");
            }
        }

        public void MonthlyUpdate()
        {
            DateTime dt = DateTime.Now;
            //int today_day = Convert.ToInt32(dt.Day);
            int today_month = Convert.ToInt32(dt.Month);

            string query = "SELECT TOP 1 (id) FROM dbo.KHTN2021 ORDER BY id DESC ";
            int id = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));

            query = "SELECT * FROM dbo.KHTN2021 WHERE id = @id ";
            DataTable dtbl = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            DataRow row = dtbl.Rows[0];

            #region split data
            int db_current_income, db_current_outcome, db_num_months, db_current_charge, db_nxt_charge, db_current_month;
            db_current_income = Convert.ToInt32(row["current_income"]);
            db_current_outcome = Convert.ToInt32(row["current_outcome"]);
            db_current_charge = Convert.ToInt32(row["charge"]);
            db_nxt_charge = Convert.ToInt32(row["next_month_charge"]);
            db_current_month = Convert.ToInt32(row["current_month"]);
            #endregion

            query = "SELECT COUNT(*) FROM dbo.MonthlyFunding WHERE funded = 1";
            int num_person = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));

            if (db_current_month == today_month)
            {
                return;
            }

            int i;

            db_current_income += num_person * db_current_charge;
            query = "UPDATE dbo.KHTN2021 SET current_income = @db_current_income , num_months = num_months + 1 WHERE id = @id ";
            i = DataProvider.Instance.ExecuteNonQuery(query, new object[] { db_current_income, id });

            if (db_current_charge != db_nxt_charge)
            {
                query = "INSERT INTO dbo.KHTN2021 (charge, next_month_charge, current_month) " +
                        "VALUES ( @charge , @next_month_charge , @current_month ) ";
                i = DataProvider.Instance.ExecuteNonQuery(query, new object[] { db_nxt_charge, db_nxt_charge, today_month });
                id++;
            }

            query = "UPDATE dbo.KHTN2021 SET current_month = @today_month WHERE id = @id ";
            i = DataProvider.Instance.ExecuteNonQuery(query, new object[] { today_month, id });
            IncreaseDebt();
            ResetFundedColumn();
        }

        void IncreaseDebt()
        {
            string query = "SELECT MSSV FROM dbo.MonthlyFunding WHERE funded = 0 ";
            DataTable dtbl = new DataTable();
            dtbl = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow dr in dtbl.Rows)
            {
                int mssv = Convert.ToInt32(dr["MSSV"]);
                query = "UPDATE dbo.MonthlyFunding SET debt = debt + 1 WHERE MSSV = @mssv ";

                int i = DataProvider.Instance.ExecuteNonQuery(query, new object[] { mssv });
            }
        }

        void ResetFundedColumn()
        {
            string query = "UPDATE dbo.MonthlyFunding SET funded = 0 ";
            int i = DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
