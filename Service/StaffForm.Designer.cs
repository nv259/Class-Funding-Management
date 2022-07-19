namespace Service
{
    partial class StaffForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.user_dtgv = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.filterBox = new System.Windows.Forms.ComboBox();
            this.mssv_txtBox = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.phone_txtBox = new System.Windows.Forms.TextBox();
            this.email_txtBox = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.staff_pnl = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.typeAnnouncement_txtBox = new System.Windows.Forms.ComboBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.amount_txtBox = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.link_txtBox = new System.Windows.Forms.TextBox();
            this.submit_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.description_txtBox = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.user_dtgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // user_dtgv
            // 
            this.user_dtgv.AllowUserToAddRows = false;
            this.user_dtgv.AllowUserToDeleteRows = false;
            this.user_dtgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.user_dtgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.user_dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.user_dtgv.Location = new System.Drawing.Point(12, 78);
            this.user_dtgv.Name = "user_dtgv";
            this.user_dtgv.ReadOnly = true;
            this.user_dtgv.RowHeadersWidth = 51;
            this.user_dtgv.RowTemplate.Height = 29;
            this.user_dtgv.Size = new System.Drawing.Size(696, 439);
            this.user_dtgv.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(12, 38);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(696, 40);
            this.textBox1.TabIndex = 1;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "DANH SÁCH THÀNH VIÊN ĐÓNG QUỸ LỚP KHTN2021";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.Location = new System.Drawing.Point(514, 523);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 27);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Filter by funded =";
            // 
            // filterBox
            // 
            this.filterBox.FormattingEnabled = true;
            this.filterBox.Items.AddRange(new object[] {
            "0",
            "1",
            "All"});
            this.filterBox.Location = new System.Drawing.Point(645, 523);
            this.filterBox.Name = "filterBox";
            this.filterBox.Size = new System.Drawing.Size(63, 28);
            this.filterBox.TabIndex = 3;
            this.filterBox.Text = "All";
            this.filterBox.SelectedIndexChanged += new System.EventHandler(this.filterBox_SelectedIndexChanged);
            // 
            // mssv_txtBox
            // 
            this.mssv_txtBox.BackColor = System.Drawing.Color.White;
            this.mssv_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mssv_txtBox.Location = new System.Drawing.Point(88, 53);
            this.mssv_txtBox.Name = "mssv_txtBox";
            this.mssv_txtBox.Size = new System.Drawing.Size(214, 27);
            this.mssv_txtBox.TabIndex = 16;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Snow;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(3, 57);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(80, 23);
            this.textBox3.TabIndex = 15;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "MSSV:";
            // 
            // phone_txtBox
            // 
            this.phone_txtBox.BackColor = System.Drawing.Color.White;
            this.phone_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phone_txtBox.Location = new System.Drawing.Point(88, 95);
            this.phone_txtBox.Name = "phone_txtBox";
            this.phone_txtBox.ReadOnly = true;
            this.phone_txtBox.Size = new System.Drawing.Size(214, 27);
            this.phone_txtBox.TabIndex = 19;
            // 
            // email_txtBox
            // 
            this.email_txtBox.BackColor = System.Drawing.Color.White;
            this.email_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email_txtBox.Location = new System.Drawing.Point(88, 139);
            this.email_txtBox.Name = "email_txtBox";
            this.email_txtBox.ReadOnly = true;
            this.email_txtBox.Size = new System.Drawing.Size(214, 27);
            this.email_txtBox.TabIndex = 20;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.Snow;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox6.Location = new System.Drawing.Point(3, 99);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(79, 23);
            this.textBox6.TabIndex = 18;
            this.textBox6.TabStop = false;
            this.textBox6.Text = "Phone:";
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.Snow;
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox10.Location = new System.Drawing.Point(3, 143);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(80, 23);
            this.textBox10.TabIndex = 19;
            this.textBox10.TabStop = false;
            this.textBox10.Text = "Email:";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox4.Location = new System.Drawing.Point(-1, -1);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(310, 40);
            this.textBox4.TabIndex = 21;
            this.textBox4.TabStop = false;
            this.textBox4.Text = "INFORMATION";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox10);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.email_txtBox);
            this.panel1.Controls.Add(this.phone_txtBox);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.mssv_txtBox);
            this.panel1.Location = new System.Drawing.Point(729, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 181);
            this.panel1.TabIndex = 4;
            // 
            // staff_pnl
            // 
            this.staff_pnl.BackColor = System.Drawing.Color.White;
            this.staff_pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.staff_pnl.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.staff_pnl.Location = new System.Drawing.Point(-1, -1);
            this.staff_pnl.Multiline = true;
            this.staff_pnl.Name = "staff_pnl";
            this.staff_pnl.ReadOnly = true;
            this.staff_pnl.Size = new System.Drawing.Size(310, 40);
            this.staff_pnl.TabIndex = 21;
            this.staff_pnl.TabStop = false;
            this.staff_pnl.Text = "STAFF ONLY";
            this.staff_pnl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.Snow;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox5.Location = new System.Drawing.Point(3, 56);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(79, 23);
            this.textBox5.TabIndex = 22;
            this.textBox5.TabStop = false;
            this.textBox5.Text = "Type:";
            // 
            // typeAnnouncement_txtBox
            // 
            this.typeAnnouncement_txtBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.typeAnnouncement_txtBox.FormattingEnabled = true;
            this.typeAnnouncement_txtBox.Items.AddRange(new object[] {
            "   Changing Charge",
            "   Create Report (Income)",
            "   Create Report (Outcome)"});
            this.typeAnnouncement_txtBox.Location = new System.Drawing.Point(88, 51);
            this.typeAnnouncement_txtBox.Name = "typeAnnouncement_txtBox";
            this.typeAnnouncement_txtBox.Size = new System.Drawing.Size(214, 28);
            this.typeAnnouncement_txtBox.TabIndex = 23;
            this.typeAnnouncement_txtBox.SelectedIndexChanged += new System.EventHandler(this.typeAnnouncement_txtBox_SelectedIndexChanged);
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.Snow;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox7.Location = new System.Drawing.Point(3, 97);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(80, 23);
            this.textBox7.TabIndex = 24;
            this.textBox7.TabStop = false;
            this.textBox7.Text = "Amount:";
            // 
            // amount_txtBox
            // 
            this.amount_txtBox.BackColor = System.Drawing.Color.White;
            this.amount_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.amount_txtBox.Location = new System.Drawing.Point(88, 97);
            this.amount_txtBox.Name = "amount_txtBox";
            this.amount_txtBox.PlaceholderText = "k vnd";
            this.amount_txtBox.Size = new System.Drawing.Size(214, 27);
            this.amount_txtBox.TabIndex = 25;
            this.amount_txtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.amount_txtBox.TextChanged += new System.EventHandler(this.amount_txtBox_TextChanged);
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.Snow;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox8.Location = new System.Drawing.Point(3, 144);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(80, 23);
            this.textBox8.TabIndex = 26;
            this.textBox8.TabStop = false;
            this.textBox8.Text = "Link:";
            // 
            // link_txtBox
            // 
            this.link_txtBox.BackColor = System.Drawing.Color.White;
            this.link_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.link_txtBox.Location = new System.Drawing.Point(88, 140);
            this.link_txtBox.Name = "link_txtBox";
            this.link_txtBox.Size = new System.Drawing.Size(214, 27);
            this.link_txtBox.TabIndex = 27;
            // 
            // submit_btn
            // 
            this.submit_btn.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.submit_btn.Location = new System.Drawing.Point(102, 252);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(107, 35);
            this.submit_btn.TabIndex = 28;
            this.submit_btn.Text = "Submit";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Snow;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.description_txtBox);
            this.panel2.Controls.Add(this.textBox12);
            this.panel2.Controls.Add(this.submit_btn);
            this.panel2.Controls.Add(this.link_txtBox);
            this.panel2.Controls.Add(this.textBox8);
            this.panel2.Controls.Add(this.amount_txtBox);
            this.panel2.Controls.Add(this.textBox7);
            this.panel2.Controls.Add(this.typeAnnouncement_txtBox);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.staff_pnl);
            this.panel2.Location = new System.Drawing.Point(729, 225);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 292);
            this.panel2.TabIndex = 5;
            // 
            // description_txtBox
            // 
            this.description_txtBox.BackColor = System.Drawing.Color.White;
            this.description_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.description_txtBox.Location = new System.Drawing.Point(88, 182);
            this.description_txtBox.Multiline = true;
            this.description_txtBox.Name = "description_txtBox";
            this.description_txtBox.Size = new System.Drawing.Size(214, 64);
            this.description_txtBox.TabIndex = 30;
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.Color.Snow;
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox12.Location = new System.Drawing.Point(3, 186);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(80, 20);
            this.textBox12.TabIndex = 29;
            this.textBox12.TabStop = false;
            this.textBox12.Text = "Description:";
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1044, 564);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.filterBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.user_dtgv);
            this.Name = "StaffForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffForm";
            ((System.ComponentModel.ISupportInitialize)(this.user_dtgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView user_dtgv;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox filterBox;
        private TextBox mssv_txtBox;
        private TextBox textBox3;
        private TextBox phone_txtBox;
        private TextBox email_txtBox;
        private TextBox textBox6;
        private TextBox textBox10;
        private TextBox textBox4;
        private Panel panel1;
        private TextBox staff_pnl;
        private TextBox textBox5;
        private ComboBox typeAnnouncement_txtBox;
        private TextBox textBox7;
        private TextBox amount_txtBox;
        private TextBox textBox8;
        private TextBox link_txtBox;
        private Button submit_btn;
        private Panel panel2;
        private TextBox description_txtBox;
        private TextBox textBox12;
    }
}