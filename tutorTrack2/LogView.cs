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
    public partial class LogView : Form
    {
        const int TabCount = 20;
        public LogView()
        {
            InitializeComponent();
        }

        private string tabber(string input)
        {
            
            string result = "";
            if (input != null)
            {
                int extra = 0;
                while (input.Length > TabCount + extra)
                {
                    extra = TabCount;
                }
                for (int i = input.Length; i < TabCount + extra; i++)
                {
                    result += " ";
                }
            }
            else
            {
                for (int i = 0; i < TabCount; i++)
                {
                    result += " ";
                }
            }
            return result;
        }

        private void LogView_Load(object sender, EventArgs e)
        {
            display.Text = "Date" + tabber("Date")
                + "Tutor" + tabber("Tutor")
                + "Client" + tabber("Client")
                + "Course" + tabber("Course") + tabber("") + tabber("")
                + "Start Time" + tabber("Start Time")
                + "End Time" + tabber("End Time") + "\n";
            List<Appointment> appointments = SingletonAppointmentList.getInstance();
            string report = "";
            foreach (var appointment in appointments)
            {
                
                report = appointment.startTime.ToShortDateString() + tabber(appointment.startTime.ToShortDateString())
                    + appointment.tutor + tabber(appointment.tutor)
                    + appointment.client + tabber(appointment.client)
                    + appointment.course + tabber(appointment.course)
                    + appointment.startTime.ToShortTimeString() + tabber(appointment.startTime.ToShortTimeString())
                    + appointment.endTime.ToShortTimeString();
                display.Text += report + "\n";
            }
        }
    }
}
