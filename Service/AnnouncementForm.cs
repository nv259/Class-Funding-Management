using DataAccess.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service
{
    public partial class AnnouncementForm : Form
    {
        private BindingSource announceList = new BindingSource();
        public AnnouncementForm(bool isStaff, int user_id)
        {
            InitializeComponent();
            if (isStaff)
            {
                update_btn.Visible = true;
                update_btn.Enabled = true;
            }
            main_dtgv.DataSource = announceList;
            AddBinding();
            LoadDtgv();
        }

        void AddBinding()
        {
            link_txtBox.DataBindings.Add("Text", main_dtgv.DataSource, "LINK");
            article_txtBox.DataBindings.Add("Text", main_dtgv.DataSource, "ARTICLE");
        }

        void LoadDtgv()
        {
            string query = "SELECT description AS ARTICLE, link AS LINK, Author_id AS AUTHOR, time AS N'PUBLIC TIME' FROM dbo.Announcement ORDER BY announcement_id DESC";
            announceList.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void openArticle_btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(link_txtBox.Text))
            {
                if (MessageBox.Show("This will direct you to Article: " + article_txtBox.Text + " through your browser", "Notification", MessageBoxButtons.OKCancel) != DialogResult.OK)
                    return;

                try
                {
                    ProcessStartInfo psInfo = new ProcessStartInfo
                    {
                        FileName = link_txtBox.Text,
                        UseShellExecute = true
                    };
                    Process.Start(psInfo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("This article (or link) is not exist!");
                }
            }
        }
    }
}
