using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace tutorTrack2
{
    public static class singletonCourseList
    {

        const string CLASS_FILE_NAME = "classes.xml";
        public static List<Course> getInstance()
        {
            if (p == null)
            {
                if (File.Exists(CLASS_FILE_NAME))
                {
                    p = xmlSerializerFunctions.FromXML<List<Course>>(CLASS_FILE_NAME);
                }
                else
                {
                    //MessageBox.Show("No Clients initialized", "Error");
                    p = new List<Course>();
                    throw new Exception();
                }
            }
            return p;
        }
        public static void saveToFile()
        {
            using (StreamWriter writer = new StreamWriter(CLASS_FILE_NAME))
            {
                string xml = xmlSerializerFunctions.ToXML(p);
                writer.Write(xml);
                writer.Close();
            }
        }
        private static List<Course> p;
    }

}
