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
    public partial class EMRegistertion : Form
    {
         
        
        
        private void RegisterTechnician()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myDB"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into [user]([name], [password], [dateOFBirth], [contact], [email], [role]) values (@name, @pasword, @DFB, @contact, @email, ' Technician'", con);
            {
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                cmd.Parameters.AddWithValue("@DateOfBirth", DateTimePickerBirth.Text);
                cmd.Parameters.AddWithValue("@Contact", txtContactNo.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.ExecuteNonQuery();

            }
            con.Close();

        }
        private void RegisterReceptionist()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myDB"].ToString());
            con.Open();
            SqlCommand cmd1 = new SqlCommand("insert into [user]([name], [password], [dateOFBirth], [contact], [email], [role]) values (@name, @pasword, @DFB, @contact, @email, 'Receptionist'", con);
            {
                cmd1.Parameters.AddWithValue("@name", txtName.Text);
                cmd1.Parameters.AddWithValue("@Password", txtPassword.Text);
                cmd1.Parameters.AddWithValue("@DateOfBirth", DateTimePickerBirth.Text);
                cmd1.Parameters.AddWithValue("@Contact", txtContactNo.Text);
                cmd1.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd1.ExecuteNonQuery();

            }
            con.Close();
        }
        
        


        public EMRegistertion()
        {
            InitializeComponent();
        }
        

        private void Registertion_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin form = new Admin();
            form.ShowDialog();
            this.Close();
        }
       
         



        


        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void brnRegister_Click(object sender, EventArgs e)
        {
            if (cmbType.SelectedIndex == 0)
            {
                if (txtName.Text != "" && txtPassword.Text != "" && txtContactNo.Text != "" && txtEmail.Text != "")
                {
                    RegisterTechnician();
                    MessageBox.Show("Technian HAve Benn Add Successfully");
                }
                else
                {
                    MessageBox.Show("Plaese Fill All The Boxes");
                }

            }
            else if (cmbType.SelectedIndex == 1)
            {
                if (txtName.Text != "" && txtPassword.Text != "" && txtContactNo.Text != "" && txtEmail.Text != "")
                {
                    RegisterReceptionist();
                    MessageBox.Show("Receptionist Have Benn Add Successfully");
                }
                else
                {
                    MessageBox.Show("Plaese Fill All The Boxes");
                }


            }
        }
    }          
}




