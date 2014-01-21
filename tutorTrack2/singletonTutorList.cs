using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using SelfBalancedTree;
using System.Xml.Serialization;

namespace tutorTrack2
{
    static class singletonTutorList
    {
        const string TUTOR_FILE_NAME = "tutors.xml";
        public static List<Tutor> getInstance()
        {
            if (p == null)
            {
                if (File.Exists(TUTOR_FILE_NAME))
                {
                    p = xmlSerializerFunctions.FromXML<List<Tutor>>(TUTOR_FILE_NAME);
                }
                else
                {
                    p = new List<Tutor>();
                    MessageBox.Show("No tutors initialized", "Error");
                    throw new Exception();
                }
            }
            return p;
        }

        public static void saveToFile()
        {
            using (StreamWriter writer = new StreamWriter("tutors.xml"))
            {
                string toFile = xmlSerializerFunctions.ToXML(p);
                writer.Write(toFile);
            }
        }

        private static List<Tutor> p = null;
    }
}
