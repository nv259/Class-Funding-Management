using DataAccess.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service
{
    public partial class StaffForm : Form
    {
        BindingSource userList = new BindingSource();
        private int staffID;
        public int StaffID { get { return staffID; } set { staffID = value; } }
        public StaffForm(int staffID)
        {
            StaffID = staffID;
            InitializeComponent();
            user_dtgv.DataSource = userList;
            Load_dtgv();
            AddBinding();
        }

        void Load_dtgv()
        {
            string query = "SELECT funded, MonthlyFunding.MSSV, phone_number, email FROM dbo.MonthlyFunding " +
                            "JOIN dbo.Person ON Person.MSSV = MonthlyFunding.MSSV ";
            userList.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void filterBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filterBox.Text == "All")
                Load_dtgv();
            else
            {
                string query = "SELECT funded, MonthlyFunding.MSSV, phone_number, email FROM dbo.MonthlyFunding " +
                                "JOIN dbo.Person ON Person.MSSV = MonthlyFunding.MSSV " +
                                "WHERE funded = @funded ";
                userList.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] { int.Parse(filterBox.Text) });
            }
        }

        void AddBinding()
        {
            mssv_txtBox.DataBindings.Add("Text", user_dtgv.DataSource, "MSSV");
            phone_txtBox.DataBindings.Add("Text", user_dtgv.DataSource, "phone_number");
            email_txtBox.DataBindings.Add("Text", user_dtgv.DataSource, "email");
        }

        private void typeAnnouncement_txtBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (typeAnnouncement_txtBox.Text)
            {
                case "   Changing Charge":
                    link_txtBox.Enabled = false;
                    description_txtBox.Text = "Changing charge to " + amount_txtBox.Text + ".000 vnd";
                    break;
                case "   Create Report (Income)":
                    link_txtBox.Text = "Will be updated later";
                    description_txtBox.Text = "Create Report (Income = " + amount_txtBox.Text + ".000 vnd)";
                    break;
                case "   Create Report (Outcome)":
                    link_txtBox.Text = "Will be updated later";
                    description_txtBox.Text = "Create Report (Outcome = " + amount_txtBox.Text + ".000 vnd)";
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            
            try
            {
                string query = "INSERT INTO dbo.Announcement (Author_id, time, description, type) " +
                                "VALUES ( @author_id , @time , @description , @type ) ";
                int i = DataProvider.Instance.ExecuteNonQuery(query, new object[] { staffID, date, description_txtBox.Text, typeAnnouncement_txtBox.Text });

                query = "SELECT TOP 1 announcement_id FROM dbo.Announcement ORDER BY announcement_id DESC";
                int id = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
                
                if (link_txtBox.Enabled)
                {

                    query = "UPDATE dbo.Announcement SET link = @link WHERE announcement_id = @id ";
                    i = DataProvider.Instance.ExecuteNonQuery(query, new object[] { link_txtBox.Text, id });
                }

                if (typeAnnouncement_txtBox.Text == "   Changing Charge")
                {
                    query = "SELECT TOP 1 id FROM dbo.KHTN2021 ORDER BY id DESC";
                    int khtn2021_id = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
                    query = "UPDATE dbo.KHTN2021 SET next_month_charge = @nxt_charge WHERE id = @id ";
                    i = DataProvider.Instance.ExecuteNonQuery(query, new object[] { Convert.ToInt32(amount_txtBox.Text), khtn2021_id });
                }

                MessageBox.Show("Task done");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void amount_txtBox_TextChanged(object sender, EventArgs e)
        {
            switch (typeAnnouncement_txtBox.Text)
            {
                case "   Changing Charge":
                    link_txtBox.Enabled = false;
                    description_txtBox.Text = "Changing charge to " + amount_txtBox.Text + ".000 vnd";
                    break;
                case "   Create Report (Income)":
                    description_txtBox.Text = "Create Report (Income = " + amount_txtBox.Text + ".000 vnd)";
                    break;
                case "   Create Report (Outcome)":
                    description_txtBox.Text = "Create Report (Outcome = " + amount_txtBox.Text + ".000 vnd)";
                    break;
            }
        }
    }
}
