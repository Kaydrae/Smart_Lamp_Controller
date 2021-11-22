using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            listofDevices.Items.Clear();
            string[] IPs = {"192.168.0.106", "192.168.0.107", "192.168.0.108", "192.168.0.109", "192.168.0.110", "192.168.0.111", "192.168.0.112","192.168.0.113"};
            for (int i = 0; i < IPs.Length; i++)
            {
                listofDevices.Items.Add(IPs[i].ToString());
            }
        }
    }
}