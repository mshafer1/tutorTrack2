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
    public partial class TutorCourseList : UserControl
    {
        Tutor current;
        public TutorCourseList()
        {
            InitializeComponent();
        }
        public void setTutor(Tutor input)
        {
            current = input;
            lblCourseID.Text = "";
            lblCourseName.Text = "";
            //List<Course> courses = current.courses.getList();
            //var courseIds = from course in courses
            //                select course.id;
            //foreach (string id in courseIds)
            //{
            //    lblCourseID.Text += id + "\n";
            //}
            //var courseNames = from course in courses
            //                select course.id;
            //foreach (string name in courseNames)
            //{
            //    lblCourseName.Text += name + "\n";
            //}
        }
        public void display()
        {
            
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
