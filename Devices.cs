using System.Windows.Forms;

namespace Smart_Lamp_Controller
{
    public class Devices
    {
        
        private string _ip;
        private string _name;
        private string _type;

        public Devices(string ip, string name, string type)
        {
            this._ip = ip;
            this._name = name;
            this._type = type;

        }

        ~Devices()
        {
            
        }

        public string Ip
        {
            get => _ip;
            set => _ip = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Type
        {
            get => _type;
            set => _type = value;
        }
    }
}