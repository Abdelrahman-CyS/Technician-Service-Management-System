using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technician Service Management System
{
    internal class TechnicianGetDetails
    {
        private string lname,mail,phone;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public string Mail { get => mail; set => mail = value; }
        public string Phone { get => phone; set => phone = value; }

        public TechnicianGetDetails(string n)
        {
            this.lname = n;
        }
        public static string CheckCompleted(int id)
        {
            //Finds the rows where ServiceStatus='Done'
            string status;
            con.Open();
            SqlCommand cmd = new SqlCommand("select ServiceStatus from Customer where Id=" + id, con);
            status = cmd.ExecuteScalar().ToString();
            con.Close();

            return status;

        }


        public static ArrayList getCustomerPending()
        {
            ArrayList arrayList = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Customer where ServiceStatus is null", con);
            SqlDataReader rd= cmd.ExecuteReader();
            while(rd.Read())
            {
                //validation made for strings longer than 15
                //padright function used to allign the columns in the listbox
                //string for FirstName and LastName longer than 15 only displays its first letter since the strings will be too long when in display
                arrayList.Add(rd.GetInt32(0).ToString());

                string r1 = rd.GetString(1);
                if (r1.Length > 15) {r1 = r1.Remove(1); }
                arrayList.Add(r1.PadRight(20 - r1.Length));

                string r2 = rd.GetString(2);
                if (r2.Length > 15) { r2 = r2.Remove(1); }
                arrayList.Add(r2.PadRight(20 - r2.Length));

                arrayList.Add(rd.GetString(3));

                arrayList.Add(rd.GetString(4).PadRight(20 - rd.GetString(4).Length));

                arrayList.Add(rd.GetDateTime(6).ToString().Remove(10));

                arrayList.Add(rd.GetString(8).PadRight(20 - rd.GetString(8).Length));

                arrayList.Add(rd.GetString(9));
                arrayList.Add("\n");
            }
            con.Close();
            return arrayList;
            //Many variations of this arraylist variable made for each page
        }
        public static ArrayList getCustomerCompleted()
        {
            ArrayList arrayList = new ArrayList();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Customer where ServiceStatus='Done'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                //Some are not validated due to the string lengths being fixed and always less than 19
                arrayList.Add(rd.GetInt32(0).ToString());

                string r1 = rd.GetString(1);
                if (r1.Length > 15) { r1 = r1.Remove(1); }
                arrayList.Add(r1.PadRight(20 - r1.Length));

                string r2 = rd.GetString(2);
                if (r2.Length > 15) { r2 = r2.Remove(1); }
                arrayList.Add(r2.PadRight(20 - r2.Length));

                arrayList.Add(rd.GetString(3));
                arrayList.Add(rd.GetString(4).PadRight(20 - rd.GetString(4).Length));
                arrayList.Add(rd.GetDateTime(6).ToString().Remove(10));
                arrayList.Add(rd.GetString(8).PadRight(18 - rd.GetString(8).Length));
                arrayList.Add(rd.GetDateTime(7).ToString().Remove(10));
                arrayList.Add(rd.GetString(12));
                arrayList.Add("\n");
            }
            con.Close();
            return arrayList;
        }

        public static ArrayList customerDetails(int ID)
        {
            ArrayList arrayList = new ArrayList();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Customer where Id='"+ID+"'", con);
            ID = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            SqlDataReader rd = cmd.ExecuteReader();
            while(rd.Read())
            {
                arrayList.Add(rd.GetInt32(0).ToString());

                string r1 = rd.GetString(1);
                if (r1.Length > 15) { r1 = r1.Remove(1); }
                arrayList.Add(r1.PadRight(20 - r1.Length));

                string r2 = rd.GetString(2);
                if (r2.Length > 15) { r2 = r2.Remove(1); }
                arrayList.Add(r2.PadRight(20 - r2.Length));

                arrayList.Add(rd.GetString(3));
                arrayList.Add(rd.GetString(4).PadRight(20 - rd.GetString(4).Length));
                arrayList.Add(rd.GetDateTime(6).ToString().Remove(10));
                arrayList.Add(rd.GetString(8));
                arrayList.Add(rd.GetString(9));
            }
            con.Close();
            return arrayList;
        }
        public static void technicianDetails(TechnicianGetDetails obj1)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Technician where LastName='" + obj1.lname + "'", con);
            
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                obj1.mail = rd.GetString(4);
                obj1.phone = rd.GetString(3);
            }
            con.Close();
        }
        public string updateTechnician(string email,string num)
        {
            string status;
            int count;
            con.Open();
            mail = email;
            phone = num;
            SqlCommand cmd = new SqlCommand("update Technician set Email='" + mail + "',ContactNumber='" + phone + "' where LastName='" + lname + "'", con);
            try
            {
                count = cmd.ExecuteNonQuery();
            }
            catch
            {
                count = 0;
            }
            if (count!=0)
            {
                status = "Update Successful";
            }
            else
            {
                status = "Update Unsuccessful";
            }
            con.Close();
            return status;
        }
    }
}
