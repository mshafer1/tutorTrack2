﻿using System;
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
    public partial class TutorLoggedIn : UserControl
    {
        Tutor currentTutor;
        Appointment appointment;
        public TutorLoggedIn()
        {
            InitializeComponent();
            btnAppointment.Focus();
            this.toggleAppointmentEventHandler += this.toggleAppointment;

            
        }

        private void toggleAppointment(object sender, EventArgs e)
        {
            if (btnAppointment.Text == "Start Appointment")
            {
                appointment = new Appointment();
                appointment.tutor = currentTutor;
                
            }
            else
            {
                appointment.finished = true;
                appointment.endTime = DateTime.Now;
            }
        }

        public void setTutor(Tutor current)
        {
            currentTutor = current;

            var appointmentOptions = (from appointments in SingletonAppointmentList.getInstance()
                                      where appointments.finished == false
                                      && appointments.tutor == currentTutor
                                      select appointments).ToList<Appointment>();

            if (appointmentOptions != null && appointmentOptions.Count > 0)
            {
                appointment = appointmentOptions[0];
                btnAppointment.Text = "Stop Appointment";
            }
            else
            {
                appointment = null;
                btnAppointment.Text = "Start Appointment";
            }
        }



        private void btnClient_Click(object sender, EventArgs e)
        {
            //show window with client information.
            ClientListDisplayForm clientForm1 = new ClientListDisplayForm();
            clientForm1.clientListing1.display(currentTutor);
            clientForm1.ShowDialog();
        }

        #region exit Tutor Event
        private void btnExit_Click(object sender, EventArgs e)
        {
            exitTutorEventHandler(sender, e);
        }

        
        public EventHandler exitTutorEventHandler;
        public delegate void exitTutorEventHandlerDelegate();
        public void exitTutorEvent(object sender, EventArgs e)
        {
            EventHandler handler = exitTutorEventHandler;
            if (handler != null)
            {
                handler(sender, e);
            }
        }
        #endregion

        #region toggle Appointment event
        private void btnAppointment_click(object sender, EventArgs e)
        {
            toggleAppointmentEventHandler(sender, e);
            exitTutorEventHandler(sender, e);
        }
        public EventHandler toggleAppointmentEventHandler;
        public delegate void toggleAppointmentEventHandlerDelegate(object sender, EventArgs e);
        public void toggleAppointmentEvent(object sender, EventArgs e)
        {
            EventHandler handler = toggleAppointmentEventHandler;
            if (handler != null)
            {
                handler(sender, e);
            }
        }
        #endregion

        private void btnCourses_Click(object sender, EventArgs e)
        {
            TutorCoursesDisplayForm display = new TutorCoursesDisplayForm();
            display.setTutor(currentTutor);
            display.ShowDialog();
        }

        private void btnAppointment_Click_1(object sender, EventArgs e)
        {
            toggleAppointmentEvent(sender, e);
        }
    }
}
