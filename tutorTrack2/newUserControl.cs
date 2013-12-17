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
    public partial class newUserControl : UserControl
    {
        List<string> courses;
        List<string> tutorNames;
        public newUserControl()
        {
            InitializeComponent();
            courses = new List<string>();
            courses.Add("Select a course");
            cBCourses.DataSource = courses ;

            tutorNames = new List<string>();
            tutorNames.Add("Select a Tutor");
            cBTutors.DataSource = tutorNames;
            cBTutors.Visible = false;
            gBtutor.Parent = gBClient.Parent = this;
            rbClient.Select();
        }

        private void rbTutor_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTutor.Checked)
            {
                gBClient.Visible = false;
                gBtutor.Visible = true;
                lbTutorCourses.DataSource = courses;
                gBtutor.Focus();
            }
            
        }

        private void rbClient_CheckedChanged(object sender, EventArgs e)
        {
            if (rbClient.Checked)
            {
                gBClient.Visible = true;
                gBtutor.Visible = false;
            }
        }

        private void tBName_MouseClick(object sender, MouseEventArgs e)
        {
            if (tBName.Text == "Enter New User Name")
            {
                tBName.Text = "";
            }
        }

        private void tBName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxID_MouseClick(object sender, MouseEventArgs e)
        {
            if (tBid.Text == "Enter New User ID (H number)")
            {
                tBid.Text = "";
            }
        }

        private void tBid_TextChanged(object sender, EventArgs e)
        {

        }




        #region client
        private void Courses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (courses.Count != 0 && courses.ElementAt(0) != "Select a course")
            {
                cBTutors.Visible = true;
                //get a set of tutor names
            }
        }

        private void Tutors_SelectedIndexChanged(object sender, EventArgs e)
        {
            //set tutor name for client and associate with tutor.
        }

        private void cBCourses_DropDown(object sender, EventArgs e)
        {

        }

        #endregion





        #region tutor

        #endregion


    }
}
