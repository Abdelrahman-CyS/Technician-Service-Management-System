namespace Technician Service Management System
{
    public partial class Admin : Form
    {
      
        public Admin()
        {
           
            InitializeComponent();
        }

        

       

        

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            EMRegistertion form = new EMRegistertion();
            form.ShowDialog();
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            Monthly_Report form = new Monthly_Report();
            form.ShowDialog();

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form = new Form4();
            form.ShowDialog();
        }

        private void brnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            TechnicianHomePage form = new TechnicianHomePage();
            form.ShowDialog();
        }
    }
}