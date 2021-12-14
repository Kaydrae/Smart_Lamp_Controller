using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Smart_Lamp_Controller
{
    public class Database
    {
        private string _connection = "Server=KEONDRAE8AA2\\SQLEXPRESS; Database=smart_lamp; Integrated Security=True;";

        private SqlConnection con;
        // 2 Tables Devices and Device_Activity
        public bool Database_Check()
        {
            try
            {
                con = new SqlConnection(_connection);
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
            if (Database_Check())
            {
                
            }
            
        }

        public void Insert(string deviceId, string url, string table)
        {
            if (Database_Check())
            {
                
            }
        }

        public void Update(Devices device)
        {
            if (Database_Check())
            {
                
            }
        }

        public void Delete(Devices device)
        {
            if (Database_Check())
            {
                
            }
        }

        public void QueryAll()
        {
            if (Database_Check())
            {
                //SqlDataAdapter adapter = new SqlDataAdapter("SELECT ID, IP, Name, Type FROM Devices", con);
                //return adapter;
            }
            else
            {
                 //return null;
            }
            

           
        }
    }

  
}