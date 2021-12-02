using System.Windows.Forms;

namespace Smart_Lamp_Controller
{
    public class Devices
    {
        private string IP = "";
        private string Name = "";
        private string Type = "";

        protected Devices(string IP, string Name, string Type)
        {
            this.IP = IP;
            this.Name = Name;
            this.Type = Type;

        }

        ~Devices()
        {
            
        }


    }
}