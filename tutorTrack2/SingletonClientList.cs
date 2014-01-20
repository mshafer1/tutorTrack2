using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace tutorTrack2
{
    static class singeltonClientList
    {
        const string User_FILE_NAME = "clients.xml";
        public static List<Client> getInstance()
        {
            if (p == null)
            {
                if (File.Exists(User_FILE_NAME))
                {
                    p = xmlSerializerFunctions.FromXML<List<Client>>(User_FILE_NAME);
                }
                else
                {
                    MessageBox.Show("No Clients initialized", "Error");
                    p = new List<Client>();
                    throw new Exception();
                }
            }
            return p;
        }
        public static void saveToFile()
        {
            using (StreamWriter writer = new StreamWriter(User_FILE_NAME))
            {
                string xml = xmlSerializerFunctions.ToXML(p);
                writer.Write(xml);
                writer.Close();
            }
        }
        private static List<Client> p;
    }
}
