using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technician Service Management System
{
    internal class RegisterCompletedService
    {
        string description, day, month, year;
        int id;
        public RegisterCompletedService(string description, string day, string month, string year,int id)
        {
            this.id = id;
            this.description = description;
            this.day = day;
            this.month = month;
            this.year = year;
        }
        private string combineDate()
        {
            string collectionDate=month+"/"+day+"/"+year;
            return collectionDate;
        }

        public string registerCompletion()
        {
            //When all input is accepted, the service status column will update to Done
            string status;
            int count;
            string cDate=combineDate();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("update Customer set CollectionDate='"+ cDate + "',ServiceDescription='"+description+"',ServiceStatus='Done' where Id='"+id+"'", con);
            try
            {
                count = cmd.ExecuteNonQuery();
            }
            catch
            {
                count=0;
            }
            
            if (count !=0)
            {
                status = "Service Request Completed";
            }
            else
            {
                status = "Invalid input has been entered";
            }
            con.Close();
            return status;
        }
    }
}
