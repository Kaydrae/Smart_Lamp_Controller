using System;
using System.Windows.Forms;

namespace Smart_Lamp_Controller
{
    public partial class Add_Device_2 : Form
    {
        private System.Windows.Forms.TextBox passTwo;
        private System.Windows.Forms.TextBox ssidtwo;
        private System.Windows.Forms.TextBox passOne;
        private System.Windows.Forms.TextBox ssidOne;
        private System.Windows.Forms.TextBox newDeviceName;
        private System.Windows.Forms.Button connectToDevice;
        private string ipAddress;
        public Add_Device_2()
        {
            InitializeComponent();
        }

        public Add_Device_2(string ipAddress)
        {
            InitializeComponent();
            this.ipAddress = ipAddress;
        }

        public ComboBox DeviceTypeList { get; set; }

        public void Add_Device_2_load(object sender, EventArgs e){
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
    
  
}