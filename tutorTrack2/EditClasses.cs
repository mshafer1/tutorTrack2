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
        private bool readyForNew;
        List<Course> availablecourses;
        public EditClasses()
        {
            InitializeComponent();
            readyForNew = false;
        }
        public void load(Tutor input)
        {
            current = input;
            SetCourseOptions();
            readyForNew = true;
        }

        

        private void lBOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (readyForNew && lBOptions.Items.Count > 0 && lBOptions.SelectedValue.ToString() == "New")
            {
                NewClassForm newClass = new NewClassForm();
                newClass.ShowDialog();
                SetCourseOptions();
                readyForNew = true;
            }
        }

        private void btnShiftRight_Click(object sender, EventArgs e)
        {
            current.addCourse((Course)lBOptions.SelectedItem);
            readyForNew = false;
            SetCourseOptions();
            if (lBOptions.Items.Count > 1)
            {
                lBOptions.SelectedIndex = 1;
            }
            else
            {
                lBOptions.SelectedIndex = 0;
            }
            readyForNew = true;
            singeltonTutorList.saveToFile();
        }

        private void btnShiftLeft_Click(object sender, EventArgs e)
        {

        }

        private void SetCourseOptions()
        {
            if (current.courses.Count() > 0)
            {
                lBCurrent.DataSource = null;
                lBCurrent.DataSource = current.courses;
            }
            availablecourses = new List<Course>(singletonCourseList.getInstance());
            if (current.courses != null && current.courses.Count() > 0)
            {
                foreach (var course in current.courses)
                {
                    Course currentCourse;
                    currentCourse = availablecourses.Find(x => x.id == course.id);
                    if (!availablecourses.Remove(currentCourse))
                        MessageBox.Show("Problemo");
                }
            }
            lBOptions.DataSource = availablecourses;
        }
    }
}