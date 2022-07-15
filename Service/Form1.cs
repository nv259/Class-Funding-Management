using DataAccess.DAO;
using DataAccess.DTO;
using System.Security.Cryptography;
using System.Text;

namespace Service
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void userName_textBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(userName_textBox.Text))
                userName_textBox.Font = new Font(userName_textBox.Font, FontStyle.Regular);
        }

        private void resetPwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void createAccBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm f = new RegisterForm();
            f.ShowDialog();
            this.Show();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM dbo.Account WHERE display_name = @name AND password = @pwd ";
            if (DataProvider.Instance.ExecuteQuery(query, new object[] { this.userName_textBox.Text, hashing(this.userPassword_textBox.Text) }).Rows.Count <= 0)
            {
                MessageBox.Show("Invalid username or password!");
                this.userPassword_textBox.Text = "";
            }
            else
            {
                Account loginAccount = AccountDAO.Instance.GetAccountByUserName(this.userName_textBox.Text);
                UserForm userForm = new UserForm(loginAccount);
                userForm.ShowDialog();
                this.Close();
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
    }
}