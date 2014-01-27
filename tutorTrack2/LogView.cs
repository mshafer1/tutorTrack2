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

        private string tabber(string input, int tabCount = TabCount)
        {
            
            string result = "";
            if (input != null)
            {
                int extra = 0;
                while (input.Length > tabCount + extra)
                {
                    extra = tabCount;
                }
                for (int i = input.Length; i < tabCount + extra; i++)
                {
                    result += " ";
                }
            }
            else
            {
                for (int i = 0; i < tabCount; i++)
                {
                    result += " ";
                }
            }
            return result;
        }

        private void set()
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
                    + appointment.course + tabber(appointment.course, TabCount * 2 + TabCount - appointment.course.Length / 2)
                    + appointment.startTime.ToShortTimeString() + tabber(appointment.startTime.ToShortTimeString())
                    + appointment.endTime.ToShortTimeString();
                display.Text += report + "\n";
            }
        }

        private void LogView_Load(object sender, EventArgs e)
        {
            set();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            SingletonAppointmentList.getInstance().Clear();
            SingletonAppointmentList.saveToFile();
            set();
        }
    }
}
