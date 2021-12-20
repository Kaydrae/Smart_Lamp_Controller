using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Smart_Lamp_Controller.Database;

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
            //MessageBox.Show(ipAddress);
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
           Close();
        }

        private void Add_Device_2_Load(object sender, EventArgs e)
        {
            if (ipAddress != "")
            {
                SSID_One_lbl.Hide();
                ssidOne.Hide();
                SSID_two_lbl.Hide();
                ssidtwo.Hide();
                pass_one_lbl.Hide();
                pass_two_lbl.Hide();
                passOne.Hide();
                passTwo.Hide();
            }
        }

        private async void connectToDevice_Click(object sender, EventArgs e)
        {
            string deviceType = listDeviceType.SelectedItem.ToString();
            string deviceName = newDeviceName.Text;

            Devices d = new Devices(ipAddress, deviceName, deviceType);

            if (deviceName.Equals(""))
            {
                MessageBox.Show("Device name must not be empty!");
            }
            else
            {
                 if (Insert(d, "Devices") < 0)
                 {
                     MessageBox.Show("Error inserting data into Database!"); 
                 }
                 else
                 {
                     MessageBox.Show("Device Added Sucessfuly.");
                     //Form1 home = new Form1();
                     //Application.OpenForms["Form1"].Dispose();
                     Application.OpenForms["Add_Device"].Close();
                     //home.Show();
                     Close();
                 }
            }
           
           

        }
    }
    
  
}