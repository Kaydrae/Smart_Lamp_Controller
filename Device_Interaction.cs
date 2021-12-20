using System;
using System.Net.Http;
using System.Windows.Forms;

namespace Smart_Lamp_Controller
{
    public partial class Device_Interaction : Form
    {
        private System.Windows.Forms.Button restart;
        private System.Windows.Forms.Button tempature;
        private Devices _devices;
        private static readonly HttpClient cli = new HttpClient();
        public Device_Interaction(Devices _devices)
        {
            InitializeComponent();
            this._devices = _devices;
            //MessageBox.Show(_devices.Ip);
            current_device_ip.Text = _devices.Ip;
            current_device_name.Text = "Current Name: " + _devices.Name;

        }

        private void SelectColor_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
            ColorDialog dlg = new ColorDialog();
            dlg.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void palette_SelectedIndexChanged(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void Device_Interaction_Load(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void power_Click(object sender, EventArgs e)
        {
           _makePostRequest(_devices.Ip, "power", "1");
        }

        private void cycle_battern_Click(object sender, EventArgs e)
        {
            _makePostRequest(_devices.Ip, "autoplay", "1");
        }

        private void brightness_Scroll(object sender, EventArgs e)
        {
            _makePostRequest(_devices.Ip, "brightness", brightness.Value.ToString());
        }

        private void cycle_palettes_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void tempature_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void restart_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        public async void _makePostRequest(string ip, string name, string value)
        {
            // set up POST request arguments
            ///Request URL: http://192.168.0.110:8080/fieldValue?name=brightness&value=255
            String URL = "Http://" + ip + ":8080/fieldValue?name=" + name + "&value=" + value;
            
            var responseString = await cli.GetStringAsync(URL);

            //MessageBox.Show(responseString);
        }

        private void pattern_SelectedIndexChanged(object sender, EventArgs e)
        {
            _makePostRequest(_devices.Ip, "autoplay", pattern.SelectedIndex.ToString());
        }
    }
}