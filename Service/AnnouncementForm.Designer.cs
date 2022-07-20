namespace Service
{
    partial class AnnouncementForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.update_btn = new System.Windows.Forms.Button();
            this.openArticle_btn = new System.Windows.Forms.Button();
            this.link_txtBox = new System.Windows.Forms.TextBox();
            this.article_txtBox = new System.Windows.Forms.TextBox();
            this.main_dtgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.main_dtgv)).BeginInit();
            this.SuspendLayout();
            // 
            // update_btn
            // 
            this.update_btn.Enabled = false;
            this.update_btn.Location = new System.Drawing.Point(689, 409);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(99, 29);
            this.update_btn.TabIndex = 3;
            this.update_btn.Text = "Update link";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Visible = false;
            this.update_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // openArticle_btn
            // 
            this.openArticle_btn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.openArticle_btn.Location = new System.Drawing.Point(346, 384);
            this.openArticle_btn.Name = "openArticle_btn";
            this.openArticle_btn.Size = new System.Drawing.Size(144, 54);
            this.openArticle_btn.TabIndex = 4;
            this.openArticle_btn.Text = "Open Article";
            this.openArticle_btn.UseVisualStyleBackColor = true;
            this.openArticle_btn.Click += new System.EventHandler(this.openArticle_btn_Click);
            // 
            // link_txtBox
            // 
            this.link_txtBox.Location = new System.Drawing.Point(563, 261);
            this.link_txtBox.Name = "link_txtBox";
            this.link_txtBox.ReadOnly = true;
            this.link_txtBox.Size = new System.Drawing.Size(125, 27);
            this.link_txtBox.TabIndex = 5;
            // 
            // article_txtBox
            // 
            this.article_txtBox.Location = new System.Drawing.Point(440, 113);
            this.article_txtBox.Name = "article_txtBox";
            this.article_txtBox.Size = new System.Drawing.Size(125, 27);
            this.article_txtBox.TabIndex = 6;
            // 
            // main_dtgv
            // 
            this.main_dtgv.AllowUserToAddRows = false;
            this.main_dtgv.AllowUserToDeleteRows = false;
            this.main_dtgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.main_dtgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.main_dtgv.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.main_dtgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.main_dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.main_dtgv.Dock = System.Windows.Forms.DockStyle.Top;
            this.main_dtgv.Location = new System.Drawing.Point(0, 0);
            this.main_dtgv.Name = "main_dtgv";
            this.main_dtgv.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.main_dtgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.main_dtgv.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.main_dtgv.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.main_dtgv.RowTemplate.Height = 29;
            this.main_dtgv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.main_dtgv.Size = new System.Drawing.Size(800, 378);
            this.main_dtgv.TabIndex = 7;
            // 
            // AnnouncementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.main_dtgv);
            this.Controls.Add(this.article_txtBox);
            this.Controls.Add(this.link_txtBox);
            this.Controls.Add(this.openArticle_btn);
            this.Controls.Add(this.update_btn);
            this.Name = "AnnouncementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AnnouncementForm";
            ((System.ComponentModel.ISupportInitialize)(this.main_dtgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button update_btn;
        private Button openArticle_btn;
        private TextBox link_txtBox;
        private TextBox article_txtBox;
        private DataGridView main_dtgv;
    }
}