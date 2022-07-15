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

        }
    }
}