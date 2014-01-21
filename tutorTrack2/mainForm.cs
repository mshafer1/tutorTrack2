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
    public partial class mainForm : Form
    {
        private static List<Tutor> tutors;
        private static List<Client> clients;
        private static List<AdminUser> admin;
        private static List<Appointment> log;


        public mainForm()
        {
            InitializeComponent();
            login1.loginEventHandler += this.loginFunction;
            admin1.newUserEventHandler += this.newUser;
            admin1.timeSheetsEventHandler += this.timeSheet;
            admin1.viewLogsEventHandler += this.viewLogs;
            newUserControl1.newUserFinishedEventHandler += this.viewLogin;
            tutorLoggedIn1.exitTutorEventHandler += this.viewLogin;
            tutorLoggedIn1.toggleAppointmentEventHandler += this.viewLogin;

            //newUserControl1 = new newUserControl();
            newUserControl1.Visible = false;
            admin1.Visible = false;
            login1.Visible = true;

            try
            {
                admin = singletonAdminList.getInstance();
            }
            catch (Exception)
            {
                admin = singletonAdminList.getInstance();
                runAdmin();
            }

            try
            {
                tutors = singletonTutorList.getInstance();
            }
            catch (Exception)
            {
                tutors = singletonTutorList.getInstance();
                runAdmin();
            }

            try
            {
                clients = singeltonClientList.getInstance();
            }
            catch (Exception)
            {
                clients = singeltonClientList.getInstance();
                runAdmin();
            }

            
        }


        private void viewLogin(object sender, EventArgs e)
        {
            this.login1.Visible = true;
            login1.Reset();
            admin1.Visible = false;
            newUserControl1.Visible = false;
            tutorLoggedIn1.Visible = false;
        }

        private void viewLogs(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void timeSheet(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void newUser(object sender, EventArgs e)
        {
            admin1.Visible = false;

            newUserControl1.Visible = true;
        }

        private void runAdmin()
        {
            admin1.Visible = true;
            login1.Visible = false;
            newUserControl1.Visible = false;
            admin1.Focus();
        }

        private void loginFunction(object sender, EventArgs e)
        {
            User current = new User();
            current.Id = login1.id;

            #region check to see if user logging in is admin
            AdminUser currentAdmin = new AdminUser(current);
            System.Predicate<AdminUser> tempAdmin = new Predicate<AdminUser>(x => x.Id != currentAdmin.Id);
            currentAdmin = admin.Find(input => input.Id == currentAdmin.Id);
            if (currentAdmin != null)
            {
                runAdmin();
            }
            #endregion
            else
            {
                #region check to see if user logging in is a tutor
                Tutor currentTutor = new Tutor(current);
                System.Predicate<Tutor> temp = new Predicate<Tutor>(x => x.Id == current.Id);
                currentTutor = tutors.Find(temp);
                if (currentTutor != null)
                {

                    if (current != new Tutor())
                    {
                        tutorLoggedIn1.setTutor(currentTutor);
                        tutorLoggedIn1.Visible = true;
                        login1.Visible = false;
                        tutorLoggedIn1.Visible = true;
                    }

                }
            #endregion
                #region if not tutor or admin
                else
                {
                    login1.Visible = true;
                    login1.Reset();
                    MessageBox.Show("Your id is not recognized as a tutor in the system. Please see system administrator for assistance.", "Error");
                }
                #endregion
            }

            
        }


    }
}
