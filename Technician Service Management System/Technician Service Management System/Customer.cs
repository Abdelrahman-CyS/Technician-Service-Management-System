using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Technician Service Management System
{
    internal class Customer
    {
        private int ID;
        private String Username;
        private String Password;
        private String Name;
        private String Email;
        private String Service;
        private int ContactNo;
        private Double Cost;
        private int Money;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myDB"].ToString());

        public string Service1 { get => Service; set => Service = value; }
        public int ID1 { get => ID; set => ID = value; }
        public string Username1 { get => Username; set => Username = value; }
        public string Password1 { get => Password; set => Password = value; }
        public string Name1 { get => Name; set => Name = value; }
        public string Email1 { get => Email; set => Email = value; }
        public int ContactNo1 { get => ContactNo; set => ContactNo = value; }
        public double Cost1 { get => Cost; set => Cost = value; }

        public Customer(string name, string unname, string email, string password, int co, string se, int cos)
        {
            Username = unname;
            Password = password;
            Name = name;
            Email = email;
            ContactNo = co;
            Service = se;
            Cost = cos;
        }

        public Customer(String unname, String email)
        {
            Username = unname;
            Email = email;
        }
        public Customer(String unname, String email, int pa)
        {
            Username = unname;
            Email = email;
            Money = pa;
        }
        public Customer(int d)
        {
            ID = d;
        }
        public Customer(String username)
        {
            Username = username;
        }

        public static void CProfile(Customer o1)
        {
            con.Open();
            SqlCommand show = new SqlCommand("Select * From All_Accounts Where Username='" + o1.Username + "'", con);
            SqlDataReader ch = show.ExecuteReader();
            while (ch.Read())
            {
                o1.ID = ch.GetInt32(0);
                o1.Name = ch.GetString(1);
                o1.Username = ch.GetString(2);
                o1.Email = ch.GetString(3);
                o1.Password = ch.GetString(4);
                o1.ContactNo = ch.GetInt32(5);
            }
            con.Close();
        }
        public void pay(int am)
        {
            con.Open();
            SqlCommand check = new SqlCommand("select * from Customer_Accounts where Username=@us and Email=@em", con);
            check.Parameters.AddWithValue("@us", Username);
            check.Parameters.AddWithValue("@em", Email);
            SqlDataReader read = check.ExecuteReader();
            read.Read();
            int Total = Convert.ToInt32(read["Amount_Paid"]);
            Money = am + Total;
            con.Close();
            con.Open();
            SqlCommand mon = new SqlCommand("Update Customer_Accounts Set Amount_Paid='" +Money+ "'where Username=@us and Email=@em", con);
            mon.Parameters.AddWithValue("@us", Username);
            mon.Parameters.AddWithValue("@em", Email);
            mon.ExecuteNonQuery();
            con.Close();
        }


        public String RegisterCustomer()
        {
            String Result = "";
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from All_Accounts where username=@us", con);
            cmd.Parameters.AddWithValue("@us", Username);
            int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            if (count > 0)
            {
                Result = "Already Used Username";
            }
            else
            {
                SqlCommand add = new SqlCommand("Insert into All_Accounts(Name, Username, Email, Password, Contact_No, Role) Values (@name,@usname,@email,@password,@con,'Customer')", con);
                SqlCommand add2 = new SqlCommand("Insert into Customer_Accounts(Username, Email, Services, Amount_paid, Services_Cost) Values (@username,@email,@se,'0',@co)", con);
                add.Parameters.AddWithValue("@name", Name);
                add.Parameters.AddWithValue("@usname", Username);
                add.Parameters.AddWithValue("@email", Email);
                add.Parameters.AddWithValue("@password", Password);
                add.Parameters.AddWithValue("@con", ContactNo);
                add2.Parameters.AddWithValue("@username", Username);
                add2.Parameters.AddWithValue("@email", Email);
                add2.Parameters.AddWithValue("@se", Service);
                add2.Parameters.AddWithValue("@co", Cost);

                add2.ExecuteNonQuery();
                int T = add.ExecuteNonQuery();
                if (T != 0)
                    Result = "Registration Successfull";
                else
                    Result = "Registration fail";
            }
            con.Close();
            return Result;


        }
        public String UpdateService(String ua, string ser, int c)
        {
            String Update;
            con.Open();
            Service = ser;
            Username = ua;
            Cost = c;
            SqlCommand mon = new SqlCommand("Update Customer_Accounts Set Services ='" + Service + "',Services_Cost ='" + Cost +"'where Username = @u", con);
            mon.Parameters.AddWithValue("@u", Username);
            int i = mon.ExecuteNonQuery();
            if (i != 0)
                Update = "Service and its cost has been Updated succsesfully";
            else
                Update = "Service Exist please try again";
            con.Close();
            return Update;
        }
        public static void Customer_Profile(Customer o1)
        {
            con.Open();
            SqlCommand show = new SqlCommand("Select * From Customer_Accounts Where Username='" + o1.Username + "'", con);
            SqlDataReader ch = show.ExecuteReader();
            while (ch.Read())
            {
                o1.Service = ch.GetString(3);
                o1.Cost = ch.GetDouble(5);
            }
            con.Close();
        }

        public String UpdateCUsername(String us, String em)
        {
            String Update;
            con.Open();
            Username = us;
            Email = em;
            SqlCommand cmd = new SqlCommand("select count(*) from All_Accounts where Username='" + Username + "'", con);
            int check = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            if (check > 0)
            {
                Update = "Username Exist please try again";
            }
            else
            {
                SqlCommand mon1 = new SqlCommand("Update All_Accounts Set Username='" + Username + "'where Id =@ID", con);
                SqlCommand mon = new SqlCommand("Update Customer_Accounts Set Username='" + Username + "'where Email=@em", con);
                mon.Parameters.AddWithValue("@em", Email);
                mon1.Parameters.AddWithValue("@ID", ID);
                mon1.ExecuteNonQuery();
                int i = mon.ExecuteNonQuery();
                if (i != 0)
                    Update = "Username Updated succsesfully";
                else
                    Update = "Unable to update username";
            }
            con.Close();
            return Update;
        }
        public String UpdateCPassword(String pass, String u)
        {
            String Update;
            con.Open();
            Password = pass;
            Username = u;
            SqlCommand mon = new SqlCommand("Update All_Accounts Set Password='" + Password + "'where Username =@u", con);
            mon.Parameters.AddWithValue("@u", Username);
            int i = mon.ExecuteNonQuery();
            if (i != 0)
            {
                Update = "Password Updated succsesfully";
            }
            else
                Update = "Unable to update Password";
            con.Close();
            return Update;
        }
    }
}
