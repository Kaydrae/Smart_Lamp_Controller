using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Smart_Lamp_Controller
{
    public class Database
    {
        private string _connection = "Server=KEONDRAE8AA2\\SQLEXPRESS; Database=smart_lamp; Integrated Security=True;";
        // 2 Tables Devices and Device_Activity
        public bool Database_Check()
        {
            try
            {
                SqlConnection con =
                    new SqlConnection(_connection);
                con.Open();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
        }

        public void Insert(Devices device, string table)
        {
            
        }

        public void Insert(string deviceId, string url, string table)
        {
            
        }

        public void Update(Devices device)
        {
            
        }

        public void Delete(Devices device)
        {
            
        }

        public void QueryAll()
        {
            
        }
    }

  
}