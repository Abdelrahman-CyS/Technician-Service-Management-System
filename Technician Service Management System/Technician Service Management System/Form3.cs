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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string First_Name;
            string Last_Name;
            float Phone_Number;
            float Repair_Fees;
            First_Name = string.Format(FirsttextBox1.Text);
            Last_Name = string.Format(LasttextBox2.Text);
            Phone_Number = float.Parse(PhontextBox3.Text);
            Repair_Fees = float.Parse(PhontextBox3.Text);


            Console.WriteLine("*************************************************\n");
            Console.WriteLine("*****          Fees Payment System          *****\n");
            Console.WriteLine("*************************************************\n");
            Console.WriteLine("Date : " + DateTime.Now + "\n\n");

            
            Console.WriteLine("First Name : " + FirsttextBox1.Text + "\n\n");
            Console.WriteLine("Last Name : " + LasttextBox2.Text + "\n\n");
            Console.WriteLine("Type of Repaie : " + groupBox1.Text + "\n\n");
            Console.WriteLine("Type of Status : " + TypSlistBox1 + "\n\n");
            Console.WriteLine("Phone Number : " + PhontextBox3 + "\n\n");
            Console.WriteLine("Amount : " + FeestextBox4 + "\n\n");


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form = new Form4();
            form.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FirsttextBox1.Clear();
            FeestextBox4.Clear();
            TypSlistBox1.ClearSelected();
            LasttextBox2.Clear();
            PhontextBox3.Clear();
            



        }

        private void firsttextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lasttextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void backbutton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form = new Form2();
            form.ShowDialog();
            this.Close();
        }

        private void LasttextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void PhontextBox3_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
