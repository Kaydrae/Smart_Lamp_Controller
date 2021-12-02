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
            //listofDevices.Columns.Add("jj", 50);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            //throw new System.NotImplementedException();
        }

        private void getDeviceInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // throw new System.NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void Add_Device_Btn_Click(object sender, EventArgs e)
        {
            Add_Device f2 = new Add_Device(); //this is the change, code for redirect  
            f2.ShowDialog(); 
        }

        private void Connect_To_Device_btn_Click(object sender, EventArgs e)
        {
            string text = listofDevices.GetItemText(listofDevices.SelectedItem);
            MessageBox.Show(text);
            Device_Interaction d1 = new Device_Interaction();
            d1.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=KEONDRAE8AA2\\SQLEXPRESS; Database=smart_lamp; Integrated Security=True;");
            con.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT ID, IP, Name FROM Devices", con);
            adapter.Fill(ds);
            //MessageBox.Show(ds.Tables[0].ToString());
            listofDevices.Items.Clear();
            this.listofDevices.DataSource = ds.Tables[0]; 
            this.listofDevices.DisplayMember = "Name"; 
            
        }

        private void dBConnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //KEONDRAE8AA2\SQLEXPRESS
            
            SqlConnection con = new SqlConnection("Server=KEONDRAE8AA2\\SQLEXPRESS; Database=smart_lamp; Integrated Security=True;");
            con.Open();
            SqlCommand cmd;
            Console.WriteLine(con.ToString());
            MessageBox.Show(con.ToString());
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}