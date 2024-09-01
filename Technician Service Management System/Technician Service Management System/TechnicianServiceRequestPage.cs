using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Technician Service Management System
{
    public partial class TechnicianServiceRequestPage : Form
    {
        int id;
        public TechnicianServiceRequestPage()
        {
            InitializeComponent();
        }
        public TechnicianServiceRequestPage(int ID)
        {
            InitializeComponent();
            id= ID;
        }
        private void btnDone_Click(object sender, EventArgs e)
        {
            int i;
            try
            {
                i=int.Parse(txtYear.Text);
            }
            catch
            {
                i = 0;
            }
            if(i>=2022)
            {
                RegisterCompletedService obj1 = new RegisterCompletedService(txtDescription.Text, txtDay.Text, txtMonth.Text, txtYear.Text, id);
                string status = obj1.registerCompletion();
                MessageBox.Show(status);
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid input for year.");
                this.Close();
            }
            
            
        }

        private void TechnicianServiceRequest_Load(object sender, EventArgs e)
        {
            //Displays Requested Service Information about selected customer
            ArrayList arrayList = new ArrayList();
            arrayList=TechnicianGetDetails.customerDetails(id);
            string[] detail=new string[arrayList.Count];
            for(int i=0;i<arrayList.Count;i++)
            {
                detail[i] = arrayList[i].ToString();
            }
            lblCustomerID.Text = detail[0];
            lblFee.Text = detail[6];
            lblDate.Text = detail[5];
            lblServiceType.Text = detail[4];
            lblName1.Text = detail[1];
            lblName2.Text = detail[2];
            lblNum.Text = detail[3];
            lblEmail.Text = detail[7];
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            TechnicianHomePage form = new TechnicianHomePage();
            form.ShowDialog();
        }
    }
}
