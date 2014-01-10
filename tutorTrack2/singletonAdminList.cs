using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace tutorTrack2
{
    
    public static class singletonAdminList
    {
        const string ADMIN_FILE_NAME = "admin.xml";
        public static List<AdminUser> getInstance()
        {
            if (p == null)
            {
                if (File.Exists(ADMIN_FILE_NAME))
                {
                    p = xmlSerializerFunctions.FromXML<List<AdminUser>>(ADMIN_FILE_NAME);
                }
                else
                {
                    p = new List<AdminUser>();
                    throw new Exception("No Admin defined");
                }
            }

            return p;
        }

        public static void saveInstance()
        {
            if (p != null)
            {
                using (StreamWriter writer = new StreamWriter(ADMIN_FILE_NAME))
                {
                    string xml = xmlSerializerFunctions.ToXML(p);
                    writer.Write(xml);
                    writer.Close();
                }
            }
            else
            {
                throw new Exception("No Admin defined");
            }
        }

        private static List<AdminUser> p = null;
    }
}
