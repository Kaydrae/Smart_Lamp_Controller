using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Smart_Lamp_Controller
{
    public class Database
    {
        private static string _connection = "Server=KEONDRAE-ORYX; Database=smart_lamp; Integrated Security=True;";

        private static SqlConnection con;
        public static bool Database_Check()
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

        public static int Insert(Devices device, string table)
        {
            if (Database_Check())
            {

                string sql = "INSERT INTO " + table + " (IP, Name, Type) VALUES (@ip, @name, @type)";

                SqlCommand command = new SqlCommand(sql, con);
                command.Parameters.AddWithValue("@ip", device.Ip);
                command.Parameters.AddWithValue("@name", device.Name);
                command.Parameters.AddWithValue("@type", device.Type);
                return command.ExecuteNonQuery();
                
            }

            return -300;
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