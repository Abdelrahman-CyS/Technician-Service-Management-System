using System;
using System.Collections;
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
    public partial class TechnicianHomePage : Form
    {
        public string lname;
        
        
        public TechnicianHomePage()
        {
            InitializeComponent();
        }
        public TechnicianHomePage(string n)
        {
            InitializeComponent();
            this.lname = n;  
        }

        private string[] arrayDetail()
        {
            ArrayList arrayList = new ArrayList();

            
            arrayList = TechnicianGetDetails.getCustomerPending();
            

            
            string[] array = new string[arrayList.Count];
            for (int i = 0; i < arrayList.Count; i++)
            {
                array[i] = arrayList[i].ToString();
            }
            return array;   
        }
        private string[] customerDetail()
        {
            string[] array1 = new string[arrayDetail().Length];
            array1 = arrayDetail();

            string item = string.Join("\t", array1);
            string[] arrayItem = item.Split("\n");

            for (int i = 0; i < arrayItem.Length; i++)
            {
                //Removes empty element of array
                arrayItem[i] = arrayItem[i].Trim();
                if (arrayItem[i] == "")
                {
                    arrayItem[i] = null;
                }
            }
            return arrayItem;
        }
        private void TechnicianHome_Load(object sender, EventArgs e)
        {

            string[] arrayPending = customerDetail();
            for (int i = 0; i < arrayPending.Length; i++)
            {
                try
                {
                    lstPending.Items.Add(arrayPending[i]);
                }
                catch { }
            }


            label1.Text = "Welcome Technician " + lname;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (lstPending.SelectedItems.Count != 0)
            {
                string id = lstPending.SelectedItem.ToString();
                string[] ID = id.Split("\t");
                int id1 = int.Parse(ID[0]);
                string status=TechnicianGetDetails.CheckCompleted(id1);
                if (status =="Selection already moved to Completed List")
                {
                    MessageBox.Show(status);
                    
                }
                else
                {
                    TechnicianServiceRequestPage a = new TechnicianServiceRequestPage(id1);
                    a.ShowDialog();
                }
                
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsPage b = new SettingsPage(lname);
            b.ShowDialog();
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            CompletedListPage obj1 = new CompletedListPage();
            obj1.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            TechnicianHomePage obj1 = new TechnicianHomePage(lname);
            lstPending.Items.Clear();
            string[] arrayPending = customerDetail();
            for (int i = 0; i < arrayPending.Length; i++)
            {
                try
                {
                    lstPending.Items.Add(arrayPending[i]);
                }
                catch { }
            }
        }

        private void lstPending_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
