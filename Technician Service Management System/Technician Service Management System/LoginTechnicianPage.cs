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
    public partial class LoginTechnicianPage : Form
    {
        public LoginTechnicianPage()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            TechnicianLoginCheck obj1 = new TechnicianLoginCheck(txtUsername.Text, txtPass.Text);
            obj1.login();
            txtPass.Text = "";
            txtUsername.Text = "";
        }

        private void LoginTechnicianPage_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }
    }
}
