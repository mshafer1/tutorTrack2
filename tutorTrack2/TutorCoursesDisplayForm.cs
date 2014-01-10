using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tutorTrack2
{
    public partial class TutorCoursesDisplayForm : Form
    {
        public TutorCoursesDisplayForm()
        {
            InitializeComponent();
        }

        public void setTutor(Tutor input)
        {
            tutorCourseList1.setTutor(input);
        }
    }
}
