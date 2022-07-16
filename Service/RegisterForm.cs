using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.DAO;

namespace Service
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                try
                {
                    #region insert new user
                    // MonthlyFunding
                    string query = "IF NOT EXISTS (SELECT * FROM dbo.MonthlyFunding WHERE MSSV = @mssv1 ) " +
                                    "BEGIN " +
                                        "INSERT INTO dbo.MonthlyFunding (MSSV) VALUES ( @mssv2 ) " +
                                    "END ";
                    int i = DataProvider.Instance.ExecuteNonQuery(query, new object[] { mssv, mssv });

                    pwd = hashing(pwd);
                    // Account
                    query = "INSERT INTO dbo.Account VALUES ( @mssv , @name , @pwd , -1 ) ";
                    i = DataProvider.Instance.ExecuteNonQuery(query, new object[] { mssv, name, pwd });

                    // Person
                    query = "INSERT INTO dbo.Person VALUES ( @mssv , @fName , @lName , @email , @phone ) ";
                    i = DataProvider.Instance.ExecuteNonQuery(query, new object[] { mssv, fName, lName, email, phone });
                    #endregion
                    MessageBox.Show("Register Successfully!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    // do nothing
                }
            }
        }

        string hashing(string str)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(str);
            byte[] hashData = new MD5CryptoServiceProvider().ComputeHash(temp);

            string result = "";
            foreach(byte b in hashData)
            {
                result += b;
            }

            return result;
        }

        bool isValid()
        {
            string query;
            fName = firstName_txtBox.Text;
            lName = lastName_txtBox.Text;
            email = email_txtBox.Text;
            name = username_txtBox.Text;
            pwd = pwd_txtBox.Text;
            rePwd = confirmPwd_txtBox.Text;
            phone = PhoneNumber_txtBox.Text;
            try { mssv = int.Parse(MSSV_txtBox.Text); }
            catch { mssv = 0; }

            if (string.IsNullOrEmpty(fName) ||  string.IsNullOrEmpty(lName))
            {
                alert_txtBox.Text = "Please give us your name*";
                return false;
            }

            if (string.IsNullOrEmpty(email))
            {
                alert_txtBox.Text = "Please provide your email*";
                return false;
            }

            if (string.IsNullOrEmpty(name))
            {
                alert_txtBox.Text = "Please enter your username*";
                return false;
            }

            query = "SELECT * FROM dbo.Account WHERE display_name = @name ";
            int i = DataProvider.Instance.ExecuteNonQuery(query, new object[] { name });
            if (i >= 1)
            {
                alert_txtBox.Text = "Username is already used*";
                return false;
            }

            if (string.IsNullOrEmpty(pwd))
            {
                alert_txtBox.Text = "Please enter your password*";
                return false;
            }

            if (rePwd != pwd)
            {
                alert_txtBox.Text = "Your confirm password does not right*";
                return false;
            }

            if (mssv == 0)
            {
                alert_txtBox.Text = "MSSV is an integer*";
                return false;
            }

            if (string.IsNullOrEmpty(phone))
            {
                alert_txtBox.Text = "Please enter your phone number*";
                return false;
            }

            return true;
        }

        private string fName, lName, email, name, pwd, rePwd, phone;
        private int mssv;
    }
}
