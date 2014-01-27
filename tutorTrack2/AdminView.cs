using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;

namespace tutorTrack2
{
    public partial class AdminControl : UserControl
    {
        public AdminControl()
        {
            InitializeComponent();
        }
        #region New User
        private void btnUser_Click(object sender, EventArgs e)
        {
            newUserEvent(sender, e);
        }


        public EventHandler newUserEventHandler;
        public delegate void newUserEventHandlerDelegate(object sender, EventArgs e);
        public void newUserEvent(object sender, EventArgs e)
        {
            EventHandler handler = newUserEventHandler;
            if (handler != null)
            {
                handler(sender, e);
            }
        }
        private void btnUserView_Click(object sender, EventArgs e)
        {
            var TutorForm = new AdminViewTutors();
            TutorForm.ShowDialog();
        }
        #endregion

        #region View Logs
        private void btnLogs_Click(object sender, EventArgs e)
        {
            var display = new LogView();
            display.ShowDialog();

        }

        #endregion

        #region print time sheets

        private void printDoc(string doc)
        {

            using (StreamReader Printfile = new StreamReader(doc))
            {
                PrintDocument printDocument1 = new PrintDocument();
                printDocument1.PrinterSettings = printDialog1.PrinterSettings;
                printDocument1.PrintPage += (s, ev) =>
                {
                    float linesPerPage = 0;
                    float yPos = 0;
                    int count = 0;
                    float leftMargin = ev.MarginBounds.Left;
                    float topMargin = ev.MarginBounds.Top;
                    string line = null;
                    Font printFont = new Font("Times New Roman", 12);

                    // Calculate the number of lines per page.
                    linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics);

                    // Print each line of the file. 
                    while (count < linesPerPage && ((line = Printfile.ReadLine()) != null))
                    {
                        yPos = topMargin + (count * printFont.GetHeight(ev.Graphics));
                        ev.Graphics.DrawString(line, printFont, Brushes.Black, leftMargin, yPos, new StringFormat());
                        count++;
                    }

                    // If more lines exist, print another page. 
                    if (line != null)
                        ev.HasMorePages = true;
                    else
                        ev.HasMorePages = false;
                };

                try
                {
                    printDocument1.Print();
                    printDocument1.Dispose();
                }
                catch
                {
                }
            }
        }



        private void btnSheets_Click(object sender, EventArgs e)
        {
            var appointments = (SingletonAppointmentList.getInstance());
            var tutors = singletonTutorList.getInstance();

            if (appointments != null && appointments.Count != 0)
            {
                printDialog1.ShowDialog();
                foreach (var tutor in tutors)
                {
                    var tutorAppointments = from appointment in appointments
                                            where appointment.tutor == tutor.ToString()
                                            select appointment;
                    if (tutorAppointments != null)
                    {
                        const string timeSheetFile = "timeSheets.dat";
                        using (StreamWriter writer = new StreamWriter(timeSheetFile))
                        {
                            writer.Write(tutor.Name);
                            writer.Write("          H");
                            writer.Write(tutor.Id);
                            writer.WriteLine("");
                            writer.WriteLine("Account#: Fund:1100 Org: 3A0901 Acount: 700500 Program: 1K\nDepartment: CSS-Tutoring");  //finish this later
                            writer.WriteLine("Date               Start          End     Duration(hh:mm)");
                            foreach (var appointment in tutorAppointments)
                            {
                                if (appointment.noShow == false)
                                {
                                    writer.WriteLine(appointment.startTime.ToShortDateString() + "     "
                                        + appointment.startTime.ToShortTimeString() + "     "
                                        + appointment.endTime.ToShortTimeString() + "     "
                                        + (appointment.endTime - appointment.startTime).ToString().Substring(0, 5));
                                }
                            }
                            writer.WriteLine();
                            writer.WriteLine("Supervisor's Signature _______________________________");
                            writer.Close();
                        }
                        printDoc(timeSheetFile);

                        //blank the document once printed.
                        using (StreamWriter writer = new StreamWriter(timeSheetFile))
                        {
                            writer.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No stored Appointments");
            }
        }
        #endregion

        #region done

        private void btnDone_Click(object sender, EventArgs e)
        {
            AdminDoneEvent(sender, e);
        }

        public EventHandler AdminDoneEventHandler;
        public delegate void AdminDoneEventHandlerDelegate(object sender, EventArgs e);
        public void AdminDoneEvent(object sender, EventArgs e)
        {
            EventHandler handler = AdminDoneEventHandler;
            if (handler != null)
            {
                handler(sender, e);
            }
        }
        #endregion
    }
}
