using DataAccess.DAO;
using DataAccess.DTO;
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

namespace Service
{
    public partial class UserForm : Form
    {
        private Account userAccount;
        private Person userInfo;
        public bool IsLogout = false;
        public Account UserAccount
        {
            get { return userAccount; }
            set { userAccount = value; ChangeFormInterface(UserAccount.Role); }
        }
        public UserForm(Account acc)
        {
            InitializeComponent();
            UserAccount = acc;
        }

        void ChangeFormInterface(string type)
        {
            userInfo = PersonDAO.Instance.GetUserInfoByMSSV(userAccount.Mssv);

            #region user info
            userName_txtBox.Text = "   " + UserAccount.DisplayName;
            fullName_txtBox.Text = "   " + userInfo.FirstName + " " + userInfo.LastName;
            email_txtBox.Text = "   " + userInfo.Email;
            mssv_txtBox.Text = "   " + userInfo.Mssv.ToString();
            phoneNumber_txtBox.Text = "   " + userInfo.PhoneNumber;
            #endregion

            #region khtn2021 panel
            charge_txtBox.Text = "   " + userInfo.Funds.Charge.ToString() + ".000 vnd";
            totalIncome_txtBox.Text = "";
            totalOutcome_txtBox.Text = "";
            thisMonthIncome_txtBox.Text = "";
            thisMonthOutcome_txtBox.Text = "";
            #endregion

            #region funding panel
            yourFund_txtBox.Text = ((userInfo.Funds.April + userInfo.Funds.May + userInfo.Funds.June + userInfo.Funds.July) * userInfo.Funds.Charge).ToString() + ".000 vnd";
            #endregion

            switch (type)
            {
                case "User":
                    adminToolStripMenuItem.Enabled = false;
                    staffToolStripMenuItem.Enabled = false;
                    break;
                case "Staff":
                    adminToolStripMenuItem.Enabled = false; 
                    break;
                case "Admin":
                    staffToolStripMenuItem.Enabled = false;
                    break;
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to log out?", "Notification", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                return;
            }

            IsLogout = true;
            this.Close();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit?", "Notification", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                return;
            }

            Application.Exit();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (hashing(oldPassword_txtBox.Text) != userAccount.Password)
            {
                MessageBox.Show("Password entered is wrong!");
                clearField();
                return;
            }

            if (newPassword_txtBox.Text != confirmPassword_txtBox.Text)
            {
                MessageBox.Show("Confirm Password is wrong!");
                clearField();
                return;
            }

            string query = "UPDATE dbo.Account SET password = @pwd WHERE MSSV = @mssv";
            int i = DataProvider.Instance.ExecuteNonQuery(query, new object[] { hashing(newPassword_txtBox.Text), userAccount.Mssv });

            MessageBox.Show("Password changed successfully!");
            clearField();
        }

        void clearField()
        {
            oldPassword_txtBox.Text = "";
            newPassword_txtBox.Text = "";
            confirmPassword_txtBox.Text = "";
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

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void specialFunding_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Still working :3");
        }

        private void monthlyFunding_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Still working :3");
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm f = new AdminForm();
            f.ShowDialog();
            this.Show();
        }
    }
}
