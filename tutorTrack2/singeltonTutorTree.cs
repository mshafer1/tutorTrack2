using System;
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
            string xml = xmlSerializerFunctions.ToXML<List<Tutor>>(p);
            using (StreamWriter writer = new StreamWriter(TUTOR_FILE_NAME))
            {
                
                writer.Write(xml);
                writer.Close();
            }
        }
        private static List<Tutor> p;
    }
}
