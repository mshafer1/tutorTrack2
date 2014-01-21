using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace tutorTrack2
{
    class SingletonAppointmentList
    {
        private const string LOG_FILE_NAME = "log.dat";
        public static List<Appointment> getInstance()
        {
            if (p == null)
            {
                if (File.Exists(LOG_FILE_NAME))
                {
                    p = xmlSerializerFunctions.FromXML<List<Appointment>>(LOG_FILE_NAME);
                }
                else
                {
                    p = new List<Appointment>();
                }
            }
            return p;
        }

        public static void saveToFile()
        {
            using (StreamWriter writer = new StreamWriter(LOG_FILE_NAME))
            {
                string toFile = xmlSerializerFunctions.ToXML(p);
                writer.Write(toFile);
            }
        }

        private static List<Appointment> p = null;
    }
}
