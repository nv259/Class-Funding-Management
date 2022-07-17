namespace Service
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.MainTab = new System.Windows.Forms.TabControl();
            this.userInforTab = new System.Windows.Forms.TabPage();
            this.StatementTab = new System.Windows.Forms.TabPage();
            this.findBtn = new System.Windows.Forms.Button();
            this.searchTxtBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.showData_panel = new System.Windows.Forms.Panel();
            this.userName_txtBox = new System.Windows.Forms.TextBox();
            this.email_txtBox = new System.Windows.Forms.TextBox();
            this.phone_txtBox = new System.Windows.Forms.TextBox();
            this.lName_txtBox = new System.Windows.Forms.TextBox();
            this.fName_txtBox = new System.Windows.Forms.TextBox();
            this.mssv_txtBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Add_btn = new System.Windows.Forms.Button();
            this.userRole_comboBox = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.resetBtn = new System.Windows.Forms.Button();
            this.txtBox4 = new System.Windows.Forms.TextBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.user_dtgv = new System.Windows.Forms.DataGridView();
            this.MainTab.SuspendLayout();
            this.StatementTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.showData_panel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_dtgv)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTab
            // 
            this.MainTab.Controls.Add(this.userInforTab);
            this.MainTab.Controls.Add(this.StatementTab);
            this.MainTab.Location = new System.Drawing.Point(6, 6);
            this.MainTab.Name = "MainTab";
            this.MainTab.SelectedIndex = 0;
            this.MainTab.Size = new System.Drawing.Size(1032, 552);
            this.MainTab.TabIndex = 1;
            // 
            // userInforTab
            // 
            this.userInforTab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userInforTab.BackgroundImage")));
            this.userInforTab.Location = new System.Drawing.Point(4, 29);
            this.userInforTab.Name = "userInforTab";
            this.userInforTab.Padding = new System.Windows.Forms.Padding(3);
            this.userInforTab.Size = new System.Drawing.Size(1024, 519);
            this.userInforTab.TabIndex = 0;
            this.userInforTab.Text = "Portrait";
            this.userInforTab.UseVisualStyleBackColor = true;
            // 
            // StatementTab
            // 
            this.StatementTab.Controls.Add(this.findBtn);
            this.StatementTab.Controls.Add(this.searchTxtBox);
            this.StatementTab.Controls.Add(this.panel1);
            this.StatementTab.Location = new System.Drawing.Point(4, 29);
            this.StatementTab.Name = "StatementTab";
            this.StatementTab.Padding = new System.Windows.Forms.Padding(3);
            this.StatementTab.Size = new System.Drawing.Size(1024, 519);
            this.StatementTab.TabIndex = 1;
            this.StatementTab.Text = "Account";
            this.StatementTab.UseVisualStyleBackColor = true;
            // 
            // findBtn
            // 
            this.findBtn.Location = new System.Drawing.Point(131, 36);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(53, 27);
            this.findBtn.TabIndex = 2;
            this.findBtn.Text = "Find";
            this.findBtn.UseVisualStyleBackColor = true;
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // searchTxtBox
            // 
            this.searchTxtBox.Location = new System.Drawing.Point(3, 36);
            this.searchTxtBox.Name = "searchTxtBox";
            this.searchTxtBox.PlaceholderText = "Search by Name";
            this.searchTxtBox.Size = new System.Drawing.Size(122, 27);
            this.searchTxtBox.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.showData_panel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.user_dtgv);
            this.panel1.Location = new System.Drawing.Point(0, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 450);
            this.panel1.TabIndex = 0;
            // 
            // showData_panel
            // 
            this.showData_panel.Controls.Add(this.userName_txtBox);
            this.showData_panel.Controls.Add(this.email_txtBox);
            this.showData_panel.Controls.Add(this.phone_txtBox);
            this.showData_panel.Controls.Add(this.lName_txtBox);
            this.showData_panel.Controls.Add(this.fName_txtBox);
            this.showData_panel.Controls.Add(this.mssv_txtBox);
            this.showData_panel.Location = new System.Drawing.Point(804, 3);
            this.showData_panel.Name = "showData_panel";
            this.showData_panel.Size = new System.Drawing.Size(219, 331);
            this.showData_panel.TabIndex = 2;
            // 
            // userName_txtBox
            // 
            this.userName_txtBox.BackColor = System.Drawing.Color.LightGray;
            this.userName_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userName_txtBox.Location = new System.Drawing.Point(2, 9);
            this.userName_txtBox.Name = "userName_txtBox";
            this.userName_txtBox.Size = new System.Drawing.Size(214, 27);
            this.userName_txtBox.TabIndex = 19;
            // 
            // email_txtBox
            // 
            this.email_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email_txtBox.Location = new System.Drawing.Point(2, 295);
            this.email_txtBox.Name = "email_txtBox";
            this.email_txtBox.ReadOnly = true;
            this.email_txtBox.Size = new System.Drawing.Size(214, 27);
            this.email_txtBox.TabIndex = 18;
            // 
            // phone_txtBox
            // 
            this.phone_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phone_txtBox.Location = new System.Drawing.Point(2, 235);
            this.phone_txtBox.Name = "phone_txtBox";
            this.phone_txtBox.ReadOnly = true;
            this.phone_txtBox.Size = new System.Drawing.Size(214, 27);
            this.phone_txtBox.TabIndex = 17;
            // 
            // lName_txtBox
            // 
            this.lName_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lName_txtBox.Location = new System.Drawing.Point(2, 178);
            this.lName_txtBox.Name = "lName_txtBox";
            this.lName_txtBox.ReadOnly = true;
            this.lName_txtBox.Size = new System.Drawing.Size(214, 27);
            this.lName_txtBox.TabIndex = 16;
            // 
            // fName_txtBox
            // 
            this.fName_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fName_txtBox.Location = new System.Drawing.Point(2, 121);
            this.fName_txtBox.Name = "fName_txtBox";
            this.fName_txtBox.ReadOnly = true;
            this.fName_txtBox.Size = new System.Drawing.Size(214, 27);
            this.fName_txtBox.TabIndex = 15;
            // 
            // mssv_txtBox
            // 
            this.mssv_txtBox.BackColor = System.Drawing.SystemColors.Control;
            this.mssv_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mssv_txtBox.Location = new System.Drawing.Point(2, 64);
            this.mssv_txtBox.Name = "mssv_txtBox";
            this.mssv_txtBox.Size = new System.Drawing.Size(214, 27);
            this.mssv_txtBox.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Add_btn);
            this.panel2.Controls.Add(this.userRole_comboBox);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.resetBtn);
            this.panel2.Controls.Add(this.txtBox4);
            this.panel2.Controls.Add(this.deleteBtn);
            this.panel2.Controls.Add(this.updateBtn);
            this.panel2.Controls.Add(this.textBox10);
            this.panel2.Controls.Add(this.textBox6);
            this.panel2.Controls.Add(this.textBox8);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(704, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(321, 442);
            this.panel2.TabIndex = 1;
            // 
            // Add_btn
            // 
            this.Add_btn.Location = new System.Drawing.Point(123, 374);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(94, 29);
            this.Add_btn.TabIndex = 21;
            this.Add_btn.Text = "Add";
            this.Add_btn.UseVisualStyleBackColor = true;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // userRole_comboBox
            // 
            this.userRole_comboBox.FormattingEnabled = true;
            this.userRole_comboBox.Items.AddRange(new object[] {
            "User",
            "Staff",
            "Admin"});
            this.userRole_comboBox.Location = new System.Drawing.Point(102, 342);
            this.userRole_comboBox.Name = "userRole_comboBox";
            this.userRole_comboBox.Size = new System.Drawing.Size(115, 28);
            this.userRole_comboBox.TabIndex = 20;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(3, 347);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(66, 23);
            this.textBox3.TabIndex = 19;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "Role:";
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(223, 374);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(90, 29);
            this.resetBtn.TabIndex = 13;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // txtBox4
            // 
            this.txtBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox4.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.txtBox4.Location = new System.Drawing.Point(3, 5);
            this.txtBox4.Name = "txtBox4";
            this.txtBox4.ReadOnly = true;
            this.txtBox4.Size = new System.Drawing.Size(91, 23);
            this.txtBox4.TabIndex = 12;
            this.txtBox4.TabStop = false;
            this.txtBox4.Text = "Username:";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(123, 409);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(94, 29);
            this.deleteBtn.TabIndex = 4;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(223, 409);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(94, 29);
            this.updateBtn.TabIndex = 3;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox10.Location = new System.Drawing.Point(3, 291);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(62, 23);
            this.textBox10.TabIndex = 8;
            this.textBox10.TabStop = false;
            this.textBox10.Text = "Email:";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox6.Location = new System.Drawing.Point(3, 231);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(62, 23);
            this.textBox6.TabIndex = 6;
            this.textBox6.TabStop = false;
            this.textBox6.Text = "Phone:";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox8.Location = new System.Drawing.Point(3, 174);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(91, 23);
            this.textBox8.TabIndex = 4;
            this.textBox8.TabStop = false;
            this.textBox8.Text = "Last name:";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox4.Location = new System.Drawing.Point(3, 117);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(91, 23);
            this.textBox4.TabIndex = 2;
            this.textBox4.TabStop = false;
            this.textBox4.Text = "First name:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(3, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(62, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "MSSV:";
            // 
            // user_dtgv
            // 
            this.user_dtgv.AllowUserToAddRows = false;
            this.user_dtgv.AllowUserToDeleteRows = false;
            this.user_dtgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.user_dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.user_dtgv.Location = new System.Drawing.Point(3, 9);
            this.user_dtgv.Name = "user_dtgv";
            this.user_dtgv.ReadOnly = true;
            this.user_dtgv.RowHeadersWidth = 51;
            this.user_dtgv.RowTemplate.Height = 29;
            this.user_dtgv.Size = new System.Drawing.Size(695, 441);
            this.user_dtgv.TabIndex = 0;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 564);
            this.Controls.Add(this.MainTab);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.MainTab.ResumeLayout(false);
            this.StatementTab.ResumeLayout(false);
            this.StatementTab.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.showData_panel.ResumeLayout(false);
            this.showData_panel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_dtgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl MainTab;
        private TabPage userInforTab;
        private TabPage StatementTab;
        private Button findBtn;
        private TextBox searchTxtBox;
        private Panel panel1;
        private Panel showData_panel;
        private TextBox userName_txtBox;
        private TextBox email_txtBox;
        private TextBox phone_txtBox;
        private TextBox lName_txtBox;
        private TextBox fName_txtBox;
        private TextBox mssv_txtBox;
        private Panel panel2;
        private Button resetBtn;
        private TextBox txtBox4;
        private Button deleteBtn;
        private Button updateBtn;
        private TextBox textBox10;
        private TextBox textBox6;
        private TextBox textBox8;
        private TextBox textBox4;
        private TextBox textBox1;
        private DataGridView user_dtgv;
        private TextBox textBox3;
        private ComboBox userRole_comboBox;
        private Button Add_btn;
    }
}