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
        private string name;
        private string id;
        List<Tutor> tutors;
        private void newUserControl_Load(object sender, EventArgs e)
        {
            courses = new List<string>();
            try
            {
                tutors = singeltonTutorList.getInstance();
                if (tutors.Count != 0)
                {
                    var coursesList = (from tutor in tutors
                                       select tutor.classes());

                    foreach (Course course in (List<Course>)coursesList)
                    {
                        if (!courses.Contains(course.name))
                        {
                            courses.Add(course.name);
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
            courses = courses.Distinct().ToList<string>();
            courses.Add("New");
            cBCourses.DataSource = courses;
            lbTutorCourses.DataSource = courses;

            id = name = "";

            tutorNames = new List<string>();
            tutorNames.Add("Select a Tutor");
            cBTutors.DataSource = tutorNames;
            cBTutors.Visible = false;
            gBtutor.Parent = gBClient.Parent = this;
            rbClient.Select();
        }
        public newUserControl()
        {
            InitializeComponent();
            //courses = new List<string>();
            
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
            name = tBName.Text;
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
            id = tBid.Text;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (id.Length != 0 && name.Length != 0)
            {
                if (rbClient.Checked)
                {
                    addClient();
                }
                else
                {
                    addTutor();
                }
            }
            else
            {
                label1.Visible = name.Length == 0;
                label2.Visible = id.Length == 0;
                label3.Visible = cBCourses.SelectedItem.ToString() == "Select a course";
            }
        }



        #region client
        private void Courses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (courses.Count != 0 && courses.ElementAt(0) != "Select a course")
            {
                cBTutors.Visible = true;
                try
                {
                    tutorNames = (from tutors in singeltonTutorList.getInstance()
                                  select tutors.getName()).ToList<String>();
                }
                catch (Exception)
                {
                }
            }
        }

        private void Tutors_SelectedIndexChanged(object sender, EventArgs e)
        {
            //set tutor name for client and associate with tutor.
        }

        private void cBCourses_DropDown(object sender, EventArgs e)
        {

        }

        void addClient()
        {
            Client current = new Client();
            current.setId(id);
            current.setName(name);
            if (!singeltonUsesrList.getInstance().Contains(current))
            {

                singeltonUsesrList.getInstance().Add(current);
            }
        }

        #endregion


        #region tutor
        private void lbTutorCourses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbTutorCourses_MouseClick(object sender, MouseEventArgs e)
        {
            if (lbTutorCourses.SelectedItem != null)
            {
                string temp = lbTutorCourses.SelectedItem.ToString();
                if (lbTutorCourses.SelectedItem.ToString() == "New")
                {

                    courses.Add("testing");
                    //lbTutorCourses.ClearSelected();
                    lbTutorCourses.DataSource = null;
                    lbTutorCourses.DataSource = courses;
                }
            }
        }

        private void addTutor()
        {
            Tutor current = new Tutor();
            current.setName(name);
            current.setId(id);
            if ( !singeltonTutorList.getInstance().Contains(current))
            {
                singeltonTutorList.getInstance().Add(current);
                singeltonTutorList.saveToFile();
            }
        }
        #endregion
    }
}
