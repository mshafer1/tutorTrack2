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
            if (current.courses.GetHeightLogN() != 0)
            {
                lBCurrent.DataSource = current.courses;
            }

            lBOptions.DataSource = singletonCourseList.getInstance();
        }

        private void lBOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lBOptions.SelectedValue.ToString() == "New")
            {
                NewClassForm newClass = new NewClassForm();
                newClass.ShowDialog();
                lBOptions.DataSource = singletonCourseList.getInstance();
            }
        }
    }
}