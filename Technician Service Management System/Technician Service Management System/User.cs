using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Technician Service Management System
{
    internal class User
    {
        private String Username;
        private String Password;

        public User(String name, String password)
        {
            Username = name;
            Password = password;
        }

        public String Login(int id, String user_account)
        {
            String now = null;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myDB"].ToString());
            con.Open();
            SqlCommand check = new SqlCommand("select count(*) from All_Accounts where Username=@username and Password=@password", con);
            check.Parameters.AddWithValue("@username", Username);
            check.Parameters.AddWithValue("@password", Password);
            int count = Convert.ToInt32(check.ExecuteScalar().ToString());
            if (count > 0)
            {
                SqlCommand search = new SqlCommand("select Role from All_Accounts where Username=@username and Password=@password", con);
                search.Parameters.AddWithValue("@username", Username);
                search.Parameters.AddWithValue("@password", Password);
                String Role = search.ExecuteScalar().ToString();

                if (Role == "Admin")
                {
                    Admin form = new Admin();
                    form.ShowDialog();
                }
                else if (Role == "Reciptionest")
                {
                    Form4 form = new Form4();
                    form.ShowDialog();
                }
                else if (Role == "Technician")
                {
                    TechnicianHomePage form = new TechnicianHomePage();
                    form.ShowDialog();
                }
                else if (Role == "Customer")
                {
                    
                }
            }
            else
                MessageBox.Show("Account not Found");
            con.Close();
            return now;



        }

    }

}
