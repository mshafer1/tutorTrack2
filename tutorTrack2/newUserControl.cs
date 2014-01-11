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
                    var coursesList = singletonAvailClassesList.getInstance();

                    foreach (Course course in coursesList)
                    {
                        string line = course.commonName + ", " + course.id;
                        if (!courses.Contains(line))
                        {
                            courses.Add(line);
                        }
                    }
                    //courses.Add("testing");
                }
            }
            catch (Exception)
            {
                tutors = singeltonTutorList.getInstance();
            }
            courses = courses.Distinct().ToList<string>();
            courses.Add("Select a Course");
            courses.Add("New");
            var tutorCoursesAvail = (from tutor in singeltonTutorList.getInstance()
                                 select tutor.courses.getList());
            List<Course> temp = new List<Course>();
            foreach (var courseList in tutorCoursesAvail)
            {
                foreach (var course in courseList)
                {
                    temp.Add(course);
                }
            }
            temp.Distinct();
            foreach (var course in temp)
            {
                courses.Add(course.ToString());
            }
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
                else if (rbTutor.Checked)
                {
                    if (lbTutorCourses.SelectedItem.ToString() != "New")
                    {
                        addTutor();
                    }
                    else
                    {

                    }
                }
                else if (rdbAdmin.Checked)
                {
                    addAdmin();
                }
                this.Visible = false;
                newUserFinishedEventHandler(sender, e);
            }
            else
            {
                label1.Visible = name.Length == 0;
                label2.Visible = id.Length == 0;
                label3.Visible = cBCourses.SelectedItem.ToString() == "Select a course";
            }
        }

        public EventHandler newUserEventHandler;

        public EventHandler newUserFinishedEventHandler;
        public delegate void newUserEventHandlerDelegate(object sender, EventArgs e);
        public void newUserFinishedEvent(object sender, EventArgs e)
        {
            EventHandler handler = newUserFinishedEventHandler;
            if (handler != null)
            {
                handler(sender, e);
            }
        }

        #region client
        private void Courses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (courses.Count != 0 && cBCourses.SelectedItem.ToString() != "Select a Course")
            {
                if (cBCourses.SelectedItem.ToString() == "New")
                {
                    NewClassForm newClassForm1 = new NewClassForm();
                    newClassForm1.ShowDialog();
                    if (newClassForm1.newClass)
                    {
                        courses.Add(newClassForm1.name + ", " + newClassForm1.id);
                    }

                    //lbTutorCourses.ClearSelected();
                    cBCourses.DataSource = null;
                    cBCourses.DataSource = courses;
                    //cBCourses.SelectedIndex = courses.Count - 1;
                }
                else
                {

                    cBTutors.Visible = true;
                    try
                    {
                        //tutorNames = (from tutors in singeltonTutorList.getInstance()
                                      //select tutors.Name).ToList<String>();
                    }
                    catch (Exception)
                    {
                    }
                }
            }
        }

        private void Tutors_SelectedIndexChanged(object sender, EventArgs e)
        {
            //set tutor name for client and associate with tutor.
        }

        void addClient()
        {
            Client current = new Client();
            current.Id = id;
            current.Name = (name);
            if (!singeltonClientList.getInstance().Contains(current))
            {
                singeltonClientList.getInstance().Add(current);
            }
        }

        #endregion

        #region tutor

        private void lbTutorCourses_MouseClick(object sender, MouseEventArgs e)
        {
            if (lbTutorCourses.SelectedItem != null)
            {
                if (lbTutorCourses.SelectedItem.ToString() == "New")
                {
                    NewClassForm newClassForm1 = new NewClassForm();
                    newClassForm1.ShowDialog();
                    if (newClassForm1.newClass)
                    {
                        courses.Add(newClassForm1.name + ", " + newClassForm1.id);
                    }

                    //lbTutorCourses.ClearSelected();
                    lbTutorCourses.DataSource = null;
                    lbTutorCourses.DataSource = courses;
                }
            }
        }

        private void addTutor()
        {
            Tutor current = new Tutor();
            current.Name = (name);
            current.Id = (id);
            Course newCourse = new Course();
            newCourse.id = lbTutorCourses.SelectedValue.ToString().Substring(0, lbTutorCourses.SelectedValue.ToString().IndexOf(','));
            newCourse.name = lbTutorCourses.SelectedValue.ToString().Substring(lbTutorCourses.SelectedValue.ToString().IndexOf(',') + 2);
            current.addCourse(newCourse);
            //current.classes().Add(new Course(lbTutorCourses.SelectedValue.ToString()));
            if (!singeltonTutorList.getInstance().Contains(current))
            {
                singeltonTutorList.getInstance().Add(current);
                singeltonTutorList.saveToFile();
            }
        }
        #endregion

        #region admin
        private void rdbAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAdmin.Checked)
            {
                gBClient.Visible = false;
                gBtutor.Visible = false;
            }
        }

        private void addAdmin()
        {
            AdminUser current = new AdminUser();
            current.Id = id;
            current.Name = (name);
            singletonAdminList.getInstance().Add(current);
            singletonAdminList.saveInstance();
        }

        #endregion
    }
}