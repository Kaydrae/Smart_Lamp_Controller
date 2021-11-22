using System;
using System.Windows.Forms;

namespace Smart_Lamp_Controller
{
    public partial class Device_Interaction : Form
    {
        public Device_Interaction()
        {
            InitializeComponent();
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
    }
}