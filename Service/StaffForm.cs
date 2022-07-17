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
        public StaffForm()
        {
            InitializeComponent();
            user_dtgv.DataSource = userList;
            Load_dtgv();
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
    }
}
