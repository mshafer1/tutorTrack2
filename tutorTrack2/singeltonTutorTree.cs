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
    static class singeltonTutorTree
    {
        const string TUTOR_FILE_NAME = "tutors.xml";
        public static  AVLTree<Tutor> getInstance()
        {
            if (p == null)
            {
                if (File.Exists(TUTOR_FILE_NAME))
                {
                    using (StreamReader reader = new StreamReader(TUTOR_FILE_NAME))
                    {
                        string xml = reader.ReadToEnd();
                        p = xmlSerilizerFunctions.FromXML<AVLTree<Tutor>>(xml);
                    }
                }
                else
                {
                    MessageBox.Show("No tutors initialized","Error" );
                    throw new Exception();
                }
            }
            return p;
        }
        private static AVLTree<Tutor> p;
    }
}
