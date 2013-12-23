using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace tutorTrack2
{
    static class singeltonUsesrList
    {
        const string User_FILE_NAME = "users.xml";
        public static List<Client> getInstance()
        {
            if (p == null)
            {
                if (File.Exists(User_FILE_NAME))
                {
                    using (StreamReader reader = new StreamReader(User_FILE_NAME))
                    {
                        string xml = reader.ReadToEnd();
                        reader.Close();
                        p = xmlSerializerFunctions.FromXML<List<Client>>(xml);
                    }
                }
                else
                {
                    MessageBox.Show("No tutors initialized", "Error");
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
        private static  List<Client>  p;
    }
}
