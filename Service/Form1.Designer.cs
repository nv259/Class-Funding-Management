namespace Service
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.userName_textBox = new System.Windows.Forms.TextBox();
            this.userPassword_textBox = new System.Windows.Forms.TextBox();
            this.resetPwd = new System.Windows.Forms.TextBox();
            this.langBox = new System.Windows.Forms.ComboBox();
            this.createAccBtn = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.remPwd = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // userName_textBox
            // 
            this.userName_textBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.userName_textBox.Location = new System.Drawing.Point(12, 31);
            this.userName_textBox.Name = "userName_textBox";
            this.userName_textBox.PlaceholderText = "Enter your Username / Email";
            this.userName_textBox.Size = new System.Drawing.Size(298, 27);
            this.userName_textBox.TabIndex = 2;
            this.userName_textBox.TextChanged += new System.EventHandler(this.userName_textBox_TextChanged);
            // 
            // userPassword_textBox
            // 
            this.userPassword_textBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.userPassword_textBox.Location = new System.Drawing.Point(12, 81);
            this.userPassword_textBox.Name = "userPassword_textBox";
            this.userPassword_textBox.PlaceholderText = "Enter your Password";
            this.userPassword_textBox.Size = new System.Drawing.Size(298, 27);
            this.userPassword_textBox.TabIndex = 3;
            this.userPassword_textBox.UseSystemPasswordChar = true;
            // 
            // resetPwd
            // 
            this.resetPwd.BackColor = System.Drawing.Color.Black;
            this.resetPwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resetPwd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetPwd.ForeColor = System.Drawing.Color.Gray;
            this.resetPwd.Location = new System.Drawing.Point(12, 443);
            this.resetPwd.Name = "resetPwd";
            this.resetPwd.Size = new System.Drawing.Size(125, 20);
            this.resetPwd.TabIndex = 9;
            this.resetPwd.Text = "Forgot Password?";
            this.resetPwd.TextChanged += new System.EventHandler(this.resetPwd_TextChanged);
            // 
            // langBox
            // 
            this.langBox.AccessibleDescription = "Language ?";
            this.langBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.langBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.langBox.BackColor = System.Drawing.Color.Black;
            this.langBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.langBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.langBox.ForeColor = System.Drawing.Color.Gray;
            this.langBox.FormattingEnabled = true;
            this.langBox.Items.AddRange(new object[] {
            "Vietnamese",
            "English",
            "Spanish"});
            this.langBox.Location = new System.Drawing.Point(159, 440);
            this.langBox.Name = "langBox";
            this.langBox.Size = new System.Drawing.Size(151, 28);
            this.langBox.TabIndex = 10;
            this.langBox.Text = "English";
            // 
            // createAccBtn
            // 
            this.createAccBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createAccBtn.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.createAccBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createAccBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createAccBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.createAccBtn.Location = new System.Drawing.Point(12, 314);
            this.createAccBtn.Name = "createAccBtn";
            this.createAccBtn.Size = new System.Drawing.Size(298, 42);
            this.createAccBtn.TabIndex = 8;
            this.createAccBtn.Text = "CREATE ACCOUNT";
            this.createAccBtn.UseVisualStyleBackColor = true;
            this.createAccBtn.Click += new System.EventHandler(this.createAccBtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.loginBtn.Location = new System.Drawing.Point(12, 225);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(298, 83);
            this.loginBtn.TabIndex = 7;
            this.loginBtn.Text = "LOGIN";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // remPwd
            // 
            this.remPwd.AutoSize = true;
            this.remPwd.BackColor = System.Drawing.Color.Black;
            this.remPwd.ForeColor = System.Drawing.Color.Gray;
            this.remPwd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.remPwd.Location = new System.Drawing.Point(12, 114);
            this.remPwd.Name = "remPwd";
            this.remPwd.Size = new System.Drawing.Size(169, 24);
            this.remPwd.TabIndex = 6;
            this.remPwd.Text = "Remember Password";
            this.remPwd.UseVisualStyleBackColor = false;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.loginBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.resetPwd);
            this.Controls.Add(this.langBox);
            this.Controls.Add(this.createAccBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.remPwd);
            this.Controls.Add(this.userPassword_textBox);
            this.Controls.Add(this.userName_textBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox userName_textBox;
        private TextBox userPassword_textBox;
        private TextBox resetPwd;
        private ComboBox langBox;
        private Button createAccBtn;
        private Button loginBtn;
        private CheckBox remPwd;
    }
}