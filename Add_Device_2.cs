using System;
using System.Windows.Forms;

namespace Smart_Lamp_Controller
{
    public partial class Add_Device_2 : Form
    {
        private TextBox passTwo;
        private TextBox ssidtwo;
        private TextBox passOne;
        private TextBox ssidOne;
        private TextBox newDeviceName;
        private Button connectToDevice;

        public Add_Device_2()
        {
            InitializeComponent();
        }

        public ComboBox DeviceTypeList { get; set; }

        public void Add_Device_2_load(object sender, EventArgs e){
            
        }
    }
    
  
}