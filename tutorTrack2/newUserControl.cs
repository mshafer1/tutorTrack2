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
        List<String> courses;
        List<string> tutorNames;
        private string name;
        private string id;
        List<Tutor> tutors;
        List<Course> courseList;
        Tutor currentTutor;
        const string TUTOR_SELECT = "Select a Tutor";

        private void newUserControl_Load(object sender, EventArgs e)
        {
            rbClient.Select();
            courses = new List<string>();

            try
            {
                tutors = singletonTutorList.getInstance();
            }
            catch (Exception)
            {
                tutors = singletonTutorList.getInstance();
                rbTutor.Select();
            }

            try
            {
                courseList = singletonCourseList.getInstance().ToList<Course>();
                foreach (var course in courseList)
                {
                    courses.Add(course.ToString());
                }
            }
            catch (Exception)
            {
                courseList = singletonCourseList.getInstance();
            }


            id = name = "";



        }

        public newUserControl()
        {
            InitializeComponent();
        }

        private void rbTutor_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTutor.Checked)
            {
                gBClient.Visible = false;
            }
        }

        private void rbClient_CheckedChanged(object sender, EventArgs e)
        {
            if (rbClient.Checked)
            {
                gBClient.Visible = true;
                btnOk.TabIndex = 5;

                cBCourses.TabIndex = 3;
                cbTutors.TabIndex = 4;
                cBCourses.TabStop = true;
                cbTutors.TabStop = true;

                cBCourses.DataSource = singletonCourseList.getInstance();
            }
            else
            {
                cBCourses.TabStop = false;
                cbTutors.TabStop = false;
                btnOk.TabIndex = 4;
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
                    addTutor();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            newUserFinishedEventHandler(sender, e);
        }
        #region new User Event
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
        #endregion

        #region client

        Course currentCourse;
        Client currentClient;
        private void Courses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (courses.Count != 0 && cBCourses.SelectedItem.ToString() != "Select a Course")
            {
                if (cBCourses.SelectedItem.ToString() == "New")
                {
                    NewClassForm newClassForm1 = new NewClassForm();
                    newClassForm1.ShowDialog();
                    courses.Clear();
                    courses.Add("New");
                    foreach (var course in courseList)
                    {
                        courses.Add(course.ToString());
                    }
                    cBCourses.DataSource = null;
                    cBCourses.DataSource = courses;
                    cBCourses.SelectedIndex = courses.Count() - 1;
                }
                else
                {
                    currentCourse = Course.FromString(cBCourses.SelectedItem.ToString());
                    try
                    {
                        string input = cBCourses.SelectedItem.ToString();
                        Course temp = Course.FromString(input);
                        tutorNames = new List<string>();
                        tutorNames.Add(TUTOR_SELECT);
                        var names = (from tutor in singletonTutorList.getInstance()
                                      where tutor.courses.Find(x => x.Id == temp.Id) != null
                                      select tutor.Name).ToList<String>();
                        foreach (string name in names)
                        {
                            tutorNames.Add(name);
                        }
                        cbTutors.DataSource = tutorNames;
                    }
                    catch (Exception exception)
                    {
                        throw exception;
                    }
                }
            }
        }

        private void Tutors_SelectedIndexChanged(object sender, EventArgs e)
        {
            string temp = "";
            if(cbTutors.SelectedIndex > 0 && cbTutors.SelectedIndex <= tutorNames.Count())
            {
                temp = tutorNames[cbTutors.SelectedIndex];
            }
            if (temp.Length > 0 && temp != TUTOR_SELECT)
            {
                currentTutor = Tutor.FindTutor(temp);
            }
            else
            {
                lblTutorSelectMust.Visible = true;
            }
        }

        void addClient()
        {
            //currentTutor = Tutor.FindTutor(tutorNames[cbTutors.SelectedIndex]);
            currentClient = new Client(name, id);
            currentClient.course = currentCourse;
            currentClient.tutor = currentTutor;
            currentTutor.addClient(currentClient);
            singletonTutorList.saveToFile();
        }

        #endregion

        #region tutor

        private void addTutor()
        {
            currentTutor = new Tutor();
            currentTutor.Name = name;
            currentTutor.Id = id;
            singletonTutorList.getInstance().Add(currentTutor);
            singletonTutorList.saveToFile();
        }
        #endregion

        #region admin
        private void rdbAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAdmin.Checked)
            {
                gBClient.Visible = false;
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