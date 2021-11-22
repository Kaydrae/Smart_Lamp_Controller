using System;
using System.Windows.Forms;

namespace Smart_Lamp_Controller
{
    public partial class Add_Device : Form
    {
        private ProgressBar Connecting_to_known_ip_progress;
        private TextBox known_Ipadress_Textbox;
        private ListBox bleDeviceList;
        private ProgressBar bluetooth_Search_progress;
        private Button bleScan;
        private System.Windows.Forms.Button bleDeviceConnect;

        public Add_Device()
        {
            InitializeComponent();
        }
        

        private void Add_Device_Load(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void bleDeviceConnect_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
            Add_Device_2 f2 = new Add_Device_2(); //this is the change, code for redirect  
            f2.ShowDialog(); 
        }
    }
}