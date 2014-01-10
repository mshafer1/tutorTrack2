using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tutorTrack2
{
    public partial class EditClasses : UserControl
    {
        Tutor current;
        public EditClasses()
        {
            InitializeComponent();
        }
        public void load(Tutor input)
        {
            current = input;
            lBCurrent.DataSource = current.classes();

        }
    }
}