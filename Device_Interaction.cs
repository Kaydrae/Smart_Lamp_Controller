using System;
using System.Windows.Forms;

namespace Smart_Lamp_Controller
{
    public partial class Device_Interaction : Form
    {
        private System.Windows.Forms.Button restart;
        private System.Windows.Forms.Button tempature;
        private Devices _devices;

        public Device_Interaction(Devices devices)
        {
            InitializeComponent();
            this._devices = devices;
            MessageBox.Show(_devices.Ip);
        }

        private void SelectColor_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
            ColorDialog dlg = new ColorDialog();
            dlg.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
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
    }
}