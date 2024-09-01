using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Technician Service Management System
{
    public partial class Monthly_Report : Form
    {
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myDB"].ToString());
        
        public Monthly_Report()
        {
            InitializeComponent();
        }
      

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin form = new Admin();
            form.ShowDialog();
            this.Close();
        }

        private void Monthly_Report_Load(object sender, EventArgs e)
        {
            dateTimePickerMonths.Format = DateTimePickerFormat.Custom;
            dateTimePickerMonths.CustomFormat = "MM";
            dateTimePickerMonths.ShowUpDown = true;

            dateTimePickerYears.Format = DateTimePickerFormat.Custom;
            dateTimePickerYears.CustomFormat = "yyyy";
            dateTimePickerYears.ShowUpDown = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

       
        private void MonthlyReport()
        {
            lisReport.Items.Clear();
            int year = Convert.ToInt32(dateTimePickerYears.Value.ToString("yyyy"));
            int month = Convert.ToInt32(dateTimePickerMonths.Value.ToString("MM"));
            var firstDayOfMonth = new DateTime(year, month, 1);
            var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

            con.Open();
            SqlCommand cmd1 = new SqlCommand("select * from [order] WHERE orderdate between '" + firstDayOfMonth + "' and '" + lastDayOfMonth + "' order by orderdate", con);
            SqlCommand cmd = new SqlCommand("select sum(ordertotal) from [order] WHERE orderdate between '" + firstDayOfMonth + "' and '" + lastDayOfMonth + "'", con);
            SqlDataReader read = cmd1.ExecuteReader();

            while (read.Read())
            {
                ListViewItem listitem = new ListViewItem(read["orderId"].ToString());
                listitem.SubItems.Add(read["userID"].ToString());
                listitem.SubItems.Add(read["ServiceID"].ToString());
                listitem.SubItems.Add(read["urgency"].ToString());
                listitem.SubItems.Add(read["orderdate"].ToString());
                listitem.SubItems.Add(read["pickupdate"].ToString());
                listitem.SubItems.Add(read["orderstatus"].ToString());
                listitem.SubItems.Add(read["description"].ToString());
                listitem.SubItems.Add(read["ordertotal"].ToString());
                lisReport.Items.Add(listitem);
            }
            con.Close();
        }

        private void MonthlyIncome()
        {
            int year = Convert.ToInt32(dateTimePickerYears.Value.ToString("yyyy"));
            int month = Convert.ToInt32(dateTimePickerMonths.Value.ToString("MM"));
            var firstDayOfMonth = new DateTime(year, month, 1);
            var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

            con.Open();
            SqlCommand cmd1 = new SqlCommand("select sum(ordertotal) as monthlyincome from [order] WHERE orderdate between '" + firstDayOfMonth + "' and '" + lastDayOfMonth + "'", con);
            SqlDataReader read = cmd1.ExecuteReader();

            while (read.Read())
            {
                lblTotalincom.Text = read["monthlyincome"].ToString();
            }
            con.Close();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            MonthlyReport();
            MonthlyIncome();
        }
    }
}
