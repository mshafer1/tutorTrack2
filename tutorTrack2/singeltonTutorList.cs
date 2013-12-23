using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using SelfBalancedTree;
using System.Xml.Serialization;

namespace tutorTrack2
{
    static class singeltonTutorList
    {
        const string TUTOR_FILE_NAME = "tutors.xml";
        static int count = 0;
        public static  List<Tutor> getInstance()
        {
            
            if (p == null)
            {
                if (File.Exists(TUTOR_FILE_NAME))
                {
                    using (StreamReader reader = new StreamReader(TUTOR_FILE_NAME))
                    {
                        string xml = reader.ReadToEnd();
                        reader.Close();
                        p = xmlSerializerFunctions.FromXML<List<Tutor>>(xml);
                    }
                }
                else
                {
                    //if (count == 0)
                    {
                        //count = 1;
                        p = new List<Tutor>();
                        MessageBox.Show("No tutors initialized", "Error");
                        throw new Exception();
                    }
                }
            }
            count++;
            return p;
        }
        public static void saveToFile()
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter("students.xml"))
            {
                string xml = ToXML<List<Tutor>>(p);
                writer.Write(xml);
                writer.Close();
            }
        }
        private static List<Tutor> p = null;

        public static string ToXML<T>(T obj)
        {
            using (StringWriter stringWriter = new StringWriter(new StringBuilder()))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                xmlSerializer.Serialize(stringWriter, obj);
                return stringWriter.ToString();
            }
        }
    }
}
