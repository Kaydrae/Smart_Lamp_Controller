using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Lamp_Controller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Add_Device_Btn_Click(object sender, EventArgs e)
        {
            Add_Device f2 = new Add_Device(); //this is the change, code for redirect  
            f2.ShowDialog(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con =
                    new SqlConnection(
                        "Server=KEONDRAE-ORYX; Database=smart_lamp; Integrated Security=True;");
                con.Open();
                DataTable ds = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT ID, IP, Name, Type FROM Devices", con);
                adapter.Fill(ds);
                foreach (DataRow row in ds.Rows)
                {
                    ListViewItem item = new ListViewItem(row["Name"].ToString());
                    item.SubItems.Add(row["ID"].ToString());
                    item.SubItems.Add(row["IP"].ToString());
                    item.SubItems.Add(row["Type"].ToString());
                    listofDevices.Items.Add(item);
                }

                listofDevices.View = View.List;
            }
            catch (SystemException)
            {
                MessageBox.Show("Could not Find Database!");
            }
            
        }

        private void listofDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listofDevices.SelectedItems.Count > 0)
            {
                string message = "Name: " + listofDevices.SelectedItems[0].Text + Environment.NewLine;
                message += "ID: " + listofDevices.SelectedItems[0].SubItems[1].Text + Environment.NewLine;
                message += "IP: " + listofDevices.SelectedItems[0].SubItems[2].Text + Environment.NewLine;
                //MessageBox.Show(message);
                Devices device = new Devices(listofDevices.SelectedItems[0].SubItems[2].Text, listofDevices.SelectedItems[0].SubItems[0].Text, listofDevices.SelectedItems[0].SubItems[3].Text);
                Device_Interaction di = new Device_Interaction(device);
                di.Show();
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}