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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.main_dtgv = new System.Windows.Forms.DataGridView();
            this.update_btn = new System.Windows.Forms.Button();
            this.openArticle_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.main_dtgv)).BeginInit();
            this.SuspendLayout();
            // 
            // main_dtgv
            // 
            this.main_dtgv.AllowUserToAddRows = false;
            this.main_dtgv.AllowUserToDeleteRows = false;
            this.main_dtgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.main_dtgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.main_dtgv.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.main_dtgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.main_dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.main_dtgv.Dock = System.Windows.Forms.DockStyle.Top;
            this.main_dtgv.Location = new System.Drawing.Point(0, 0);
            this.main_dtgv.Name = "main_dtgv";
            this.main_dtgv.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.main_dtgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.main_dtgv.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.main_dtgv.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.main_dtgv.RowTemplate.Height = 29;
            this.main_dtgv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.main_dtgv.Size = new System.Drawing.Size(800, 378);
            this.main_dtgv.TabIndex = 0;
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(689, 409);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(99, 29);
            this.update_btn.TabIndex = 3;
            this.update_btn.Text = "Update link";
            this.update_btn.UseVisualStyleBackColor = true;
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
            // AnnouncementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.openArticle_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.main_dtgv);
            this.Name = "AnnouncementForm";
            this.Text = "AnnouncementForm";
            ((System.ComponentModel.ISupportInitialize)(this.main_dtgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView main_dtgv;
        private Button update_btn;
        private Button openArticle_btn;
    }
}