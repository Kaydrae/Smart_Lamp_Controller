using System.Windows.Forms;

namespace Smart_Lamp_Controller
{
    public class Devices
    {
        private int _id;
        private string _ip;
        private string _name;
        private string _type;

        public Devices(int id, string ip, string name, string type)
        {
            this._id = id;
            this._ip = ip;
            this._name = name;
            this._type = type;

        }

        ~Devices()
        {
            
        }


        public string Ip
        {
            get { return _ip; }
            set { _ip = value; }

        }
    }
}