using DataAccess.DAO;
using DataAccess.DTO;

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
            string query = "SELECT * FROM dbo.Account WHERE display_name = @name ";
            int i = DataProvider.Instance.ExecuteNonQuery(query, new object[] { this.userName_textBox.Text });

            if (i <= 0)
            {
                MessageBox.Show("Invalid username or password!");
                this.userPassword_textBox.Text = "";
            }
            else
            { 
                Account loginAccount = 
            }
        }
    }
}