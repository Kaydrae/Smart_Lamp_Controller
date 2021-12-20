using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Threading;
using System.Threading.Tasks;
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
        private System.Windows.Forms.ProgressBar bluetooth_Search_progress;
        private System.Windows.Forms.Button bleScan;
        private System.Windows.Forms.Button bleDeviceConnect;
        static BluetoothClient Blueclient = new BluetoothClient();
        static Dictionary<string, BluetoothAddress> deviceAddresses = new Dictionary<string, BluetoothAddress>();
        private Thread bleScanThread;
        String deviceName;
        String myPin = ""; //null for esp32
        List<string> items;
        bool ready = false;
        byte[] message;
        //Bluetooth
        IReadOnlyCollection<BluetoothDeviceInfo> devices = null;
        BluetoothDeviceInfo deviceInfo = null;
        public Add_Device()
        {
            items = new List<string>();
            InitializeComponent();
               bleScanThread = new Thread(ble_ScanForDevices);
        }
        

        private void Add_Device_Load(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void bleDeviceConnect_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is still under construction.");
            //throw new System.NotImplementedException();
            //Add_Device_2 f2 = new Add_Device_2(); //this is the change, code for redirect  
            //f2.ShowDialog(); 
            // try
            // {
            //     MessageBox.Show(bleDeviceList.SelectedItem.ToString());
            //     BluetoothAddress deviceAddress = deviceAddresses[bleDeviceList.SelectedItem.ToString()];
            //     //Blueclient.SetPin(DeviceAddress, txtPwd.Text.Trim());
            //     Blueclient.Connect(deviceAddress, BluetoothService.Handsfree); 
            //     MessageBox.Show("The pairing is successful.");
            // }
            // catch (Exception ex)
            // {
            //     MessageBox.Show(ex.Message);
            // }
        }

        private void bleScan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is still under construction.");
            //bleScanThread.Start();
            // bluetooth_Search_progress.Minimum = 0;
            // bluetooth_Search_progress.Maximum = 100;
            //  ble_ScanForDevices();
            // for (int i = 0; i <= 100; i++)
            // {
            //     if (bleScanThread.IsAlive)
            //     {
            //         bluetooth_Search_progress.Value = i;
            //         if (i == 99)
            //         {
            //             //i = 1;
            //            
            //         }
            //     }
            //    
            //     
            // }

        }

        private void ble_ScanForDevices()
        {
            // BluetoothClient client = new BluetoothClient();
            // List<string> items = new List<string>();
            // ///BluetoothDeviceInfo[] devices = client.DiscoverDevicesInRange();
            //
            // BluetoothRadio bluetooth = BluetoothRadio.Default;
            // bluetooth.Mode = RadioMode.Connectable;
            //  IReadOnlyCollection<BluetoothDeviceInfo> btDevices = Blueclient.DiscoverDevices();
            // bleDeviceList.Items.Clear();
            //
            // deviceAddresses.Clear();
            // foreach (BluetoothDeviceInfo device in btDevices)
            // {
            //     bleDeviceList.Items.Add(device.DeviceName);
            //     MessageBox.Show(device.DeviceName);
            //     deviceAddresses[device.DeviceName] = device.DeviceAddress;
            // }
            bleDeviceList.DataSource = null;
            BluetoothClient client = new BluetoothClient();
            devices =  client.DiscoverDevices();

            foreach (BluetoothDeviceInfo device in devices)
            {

                deviceName = device.DeviceName.ToString();
                System.Console.WriteLine(deviceName);
                MessageBox.Show(deviceName);
                items.Add(device.DeviceName);
                bleDeviceList.Items.Add(deviceName);
            }
            //bleDeviceList.DataSource = items;
          
            bleTxt.Text = "Search device is complete, searched " + bleDeviceList.Items.Count + " Bluetooth devices.";
            //bleScanThread.Set();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void IP_Known_Connnect_Btn_Click(object sender, EventArgs e)
        {
            string ipAddress = "http://" + known_Ipadress_Textbox.Text + ":8080/";
            //MessageBox.Show(ipAddress);
            //MessageBox.Show("Pingable: " + PingHost(known_Ipadress_Textbox.Text));

            if (PingHost(known_Ipadress_Textbox.Text))
            {
                Add_Device_2 ad2 = new Add_Device_2(known_Ipadress_Textbox.Text);
                ad2.Show();
            }
            else
            {
                MessageBox.Show("Check IP Address could not connect to Host");
            }


        }
        
        public static bool PingHost(string nameOrAddress)
        {
            Ping p = new Ping();
            PingReply r;
            string s;
            s = nameOrAddress;
            r = p.Send(nameOrAddress);

            if (r.Status == IPStatus.Success)
            {
                MessageBox.Show("Ping to " + nameOrAddress + "[" + r.Address + "]" + " Successful"
                                 + " Response delay = " + r.RoundtripTime + " ms" + "\n");
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}