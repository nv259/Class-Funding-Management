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
        public AnnouncementForm(bool isStaff)
        {
            //ProcessStartInfo psInfo = new ProcessStartInfo
            //{
            //    FileName = "https://docs.google.com/spreadsheets/d/1f_qkf1CXuf1r1k6cc0SW1zIDHB2NAUl7L3pTQ7AJjVI/edit?usp=sharing",
            //    UseShellExecute = true
            //};
            //Process.Start(psInfo);
            InitializeComponent();
            main_dtgv.DataSource = announceList;
            LoadDtgv();
        }

        private void newer_btn_Click(object sender, EventArgs e)
        {

        }

        private void older_btn_Click(object sender, EventArgs e)
        {

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

        }
    }
}
