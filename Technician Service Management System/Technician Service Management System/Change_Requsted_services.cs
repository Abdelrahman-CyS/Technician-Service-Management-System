using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOGIN
{
    public partial class Change_Requsted_services : Form
    {
        private String Username;
        public Change_Requsted_services()
        {
            InitializeComponent();
        }
        public Change_Requsted_services(String ua)
        {
            InitializeComponent();
            Username = ua;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            login_screen form = new login_screen();
            form.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Account_profile form = new Account_profile(Username);
            form.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Services form = new Services(Username);
            form.ShowDialog();
            this.Close();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Change_Requsted_services_Load(object sender, EventArgs e)
        {
            Customer obj1 = new Customer(Username);
            Customer.Customer_Profile(obj1);
            textBox1.Text = obj1.Service1;

        }

        private void Login_Click(object sender, EventArgs e)
        {
            int cost = Price();
            Customer obj1 = new Customer(Username);
            MessageBox.Show(obj1.UpdateService(Username,comboBox1.SelectedItem.ToString(),cost));
        }
        private int Price()
        {
            int Price;
            Price = 0;
            if (comboBox1.SelectedIndex == 0 && checkBox1.Checked)
            {
                Price = 80;
            }
            else if (comboBox1.SelectedIndex == 0)
            {
                Price = 50;
            }
            else if (comboBox1.SelectedIndex == 1 && checkBox1.Checked)
            {
                Price = 90;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                Price = 60;
            }
            else if (comboBox1.SelectedIndex == 2 && checkBox1.Checked)
            {
                Price = 430;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                Price = 380;
            }
            else if (comboBox1.SelectedIndex == 3 && checkBox1.Checked)
            {
                Price = 200;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                Price = 160;
            }
            else if (comboBox1.SelectedIndex == 4 && checkBox1.Checked)
            {
                Price = 210;
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                Price = 180;
            }
            else if (comboBox1.SelectedIndex == 5 && checkBox1.Checked)
            {
                Price = 150;
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                Price = 100;
            }
            else if (comboBox1.SelectedIndex == 6 && checkBox1.Checked)
            {
                Price = 130;
            }
            else if (comboBox1.SelectedIndex == 6)
            {
                Price = 80;
            }
            else if (comboBox1.SelectedIndex == 7 && checkBox1.Checked)
            {
                Price = 100;
            }
            else if (comboBox1.SelectedIndex == 7)
            {
                Price = 70;
            }
            return Price;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int cost = Price();
            label2.Text = "Price " + cost.ToString() + " RM";
        }
    }
}
