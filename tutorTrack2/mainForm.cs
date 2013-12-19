﻿using System;
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
        public mainForm()
        {
            InitializeComponent();
            login1.loginEventHandler += this.loginFunction;
            admin1.newUserEventHandler += this.newUser;
            admin1.timeSheetsEventHandler += this.timeSheet;
            admin1.viewLogsEventHandler += this.viewLogs;

            //newUserControl1 = new newUserControl();
            newUserControl1.Visible = false;
            admin1.Visible = false;
            login1.Visible = true;

            try
            {
                tutors = singeltonTutorList.getInstance();
            }
            catch(Exception x)
            {
                runAdmin();
            }
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
            using (Tutor current = new Tutor())
            {
                current.id = login1.id;
                System.Predicate<Tutor> temp = new Predicate<Tutor>(x => x.id != current.id);
                if (tutors.Find(temp)!=null)
                {
                    MessageBox.Show("it found you!");
                }
                else
                {
                    MessageBox.Show( "Your id is not recognized as a tutor in the system. Please see system administrator for assistance.","Error");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
