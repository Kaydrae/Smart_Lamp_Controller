using System;
using System.Collections.Generic;
using System.Windows.Forms;
using InTheHand.Net;
using InTheHand.Net.Bluetooth;
using InTheHand.Net.Sockets;


namespace Smart_Lamp_Controller
{
    public partial class Add_Device : Form
    {
        private ProgressBar Connecting_to_known_ip_progress;
        private System.Windows.Forms.TextBox known_Ipadress_Textbox;
        private System.Windows.Forms.ListBox bleDeviceList;
        private ProgressBar bluetooth_Search_progress;
        private System.Windows.Forms.Button bleScan;
        private System.Windows.Forms.Button bleDeviceConnect;

        BluetoothClient Blueclient = new BluetoothClient();
        Dictionary<string, BluetoothAddress> deviceAddresses = new Dictionary<string, BluetoothAddress>();
        
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
            //Add_Device_2 f2 = new Add_Device_2(); //this is the change, code for redirect  
            //f2.ShowDialog(); 
            try
            {
                BluetoothAddress deviceAddress = deviceAddresses[bleDeviceList.SelectedItem.ToString()];
                //Blueclient.SetPin(DeviceAddress, txtPwd.Text.Trim());
                Blueclient.Connect(deviceAddress, BluetoothService.Handsfree); 
                MessageBox.Show("The pairing is successful.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bleScan_Click(object sender, EventArgs e)
        {
            BluetoothRadio bluetooth = BluetoothRadio.Default;
            bluetooth.Mode = RadioMode.Connectable;
            IReadOnlyCollection<BluetoothDeviceInfo> btDevices = Blueclient.DiscoverDevices();
            bleDeviceList.Items.Clear();
            deviceAddresses.Clear();
            foreach (BluetoothDeviceInfo device in btDevices)
            {
                bleDeviceList.Items.Add(device.DeviceName);
                deviceAddresses[device.DeviceName] = device.DeviceAddress;
            }
 
            this.bleTxt.Text = "Search device is complete, searched " + bleDeviceList.Items.Count + " Bluetooth devices.";

        }

        private void bleTxt_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IP_Known_Connnect_Btn_Click(object sender, EventArgs e)
        {
            string ipAddress = known_Ipadress_Textbox.Text;
            //MessageBox.Show(ipAddress);
            
            
        }
    }
}