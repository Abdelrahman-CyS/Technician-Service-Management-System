using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technician Service Management System
{
    internal class TechnicianLoginCheck
    {
        string lname,pass;

        public TechnicianLoginCheck(string lname,string pass)
        {
            this.lname = lname;
            this.pass = pass;
        }

        


        public void login()
        {
            int count;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Users where Username='" + lname + "' and Password='" + pass + "'", con);
            try
            {
                count = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            }
            catch
            {
                count = 0;
            }

            
            if (count>0)
            {
                //When the inputs are both accepted until here but it does not have technician as the role, it will display a messagebox only
                string n;
                SqlCommand cmd2 = new SqlCommand("select LastName from Technician where Lastname='" + lname + "'", con);
                try
                {
                    n = cmd2.ExecuteScalar().ToString();
                    TechnicianHomePage a = new TechnicianHomePage(n);
                    a.ShowDialog();
                }
                catch
                {
                    MessageBox.Show("Username does not belong in Technician Section");
                } 
            }
            else
            {
                MessageBox.Show("Invalid Username/Password");
            }

        }
    }
}
