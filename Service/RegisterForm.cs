using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

                    MessageBox.Show("Register Successfully!");
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
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

            query = "SELECT * FROM dbo.Account WHERE name = @name ";
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
