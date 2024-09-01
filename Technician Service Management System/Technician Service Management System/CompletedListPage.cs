using System;
using System.Collections;
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
    public partial class CompletedListPage : Form
    {


        public CompletedListPage()
        {
            InitializeComponent();
        }


        private void getCompletedCustomer()
        {
            ArrayList arrayList = new ArrayList();
            arrayList = TechnicianGetDetails.getCustomerCompleted();
            string[] array = new string[arrayList.Count];
            for (int i = 0; i < arrayList.Count; i++)
            {
                array[i] = arrayList[i].ToString();
            }
            string item = string.Join("\t", array);
            string[] arrayPending = item.Split("\n");

            for (int i = 0; i < arrayPending.Length; i++)
            {
                //Removes the last empty array
                arrayPending[i] = arrayPending[i].Trim();
                if (arrayPending[i] == "")
                {
                    arrayPending[i] = null;
                }
            }
            for (int i = 0; i < arrayPending.Length; i++)
            {
                try
                {
                    lstComplete.Items.Add(arrayPending[i]);
                }
                catch { }
            }
        }
        private void CompletedList_Load(object sender, EventArgs e)
        {
            getCompletedCustomer();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //Reverts the selected id service request back to the pending listbox
            if (lstComplete.SelectedItems.Count != 0)
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

                string id = lstComplete.SelectedItem.ToString();
                string[] ID = id.Split("\t");
                int id1 = int.Parse(ID[0]);
                string status = TechnicianGetDetails.CheckCompleted(id1);
                if (status=="Done")
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update Customer set ServiceStatus =null,CollectionDate=null,ServiceDescription=null where Id=" + id1, con);
                    int count = cmd.ExecuteNonQuery();
                    if (count != 0)
                    {
                        MessageBox.Show("Selection moved to Pending List");
                    }
                }
                else
                {
                    MessageBox.Show("Selection already moved to Pending List");
                }
                
            }
            
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            lstComplete.Items.Clear();
            getCompletedCustomer();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            TechnicianHomePage form = new TechnicianHomePage();
            form.ShowDialog();
        }
    }

}
