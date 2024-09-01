using System;
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
    public partial class SettingsPage : Form
    {
        private string tName;
        public SettingsPage()
        {
            InitializeComponent();
        }
        public SettingsPage(string n)
        {
            InitializeComponent();
            this.tName = n;
        }

        private void SettingsPage_Load(object sender, EventArgs e)
        {
            //Gets technician mail and phone and displays on settings page
            TechnicianGetDetails obj1 = new TechnicianGetDetails(tName);
            TechnicianGetDetails.technicianDetails(obj1);
            txtEmail.Text = obj1.Mail;
            txtPhone.Text = obj1.Phone;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string status ="Please try again";
            bool result=false;
            TechnicianGetDetails obj2= new TechnicianGetDetails(tName);
            try
            {
                int.Parse(txtPhone.Text);
                result = true;
            }
            catch
            {
            }
            if (txtEmail.Text.Contains("@")&&txtEmail.Text.Contains(".com"))
            {
                if(txtPhone.Text.Length==10 && result==true && int.Parse(txtPhone.Text) > 0 && txtPhone.Text.Contains("+")==false)
                {
                    status = obj2.updateTechnician(txtEmail.Text, txtPhone.Text);
                    MessageBox.Show(status);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid phone number. Enter 10 digits (Malaysian phone number)");
                }  
            }
            else
            {
                MessageBox.Show("email invalid");
            }            
        }
    }
}
