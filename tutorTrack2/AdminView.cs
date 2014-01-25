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
        #endregion

        #region View Logs
        private void btnLogs_Click(object sender, EventArgs e)
        {
            viewLogsEvent(sender, e);
        }
        public EventHandler viewLogsEventHandler;
        public delegate void viewLogsEventHandlerDelegate(object sender, EventArgs e);
        public void viewLogsEvent(object sender, EventArgs e)
        {
            EventHandler handler = viewLogsEventHandler;
            if (handler != null)
            {
                handler(sender, e);
            }
        }
        #endregion

        #region print time sheets
        private void btnSheets_Click(object sender, EventArgs e)
        {
            timeSheetsEvent(sender, e);
        }
        public EventHandler timeSheetsEventHandler;
        public delegate void timeSheetsEventHandlerDelegate(object sender, EventArgs e);
        public void timeSheetsEvent(object sender, EventArgs e)
        {
            EventHandler handler = timeSheetsEventHandler;
            if (handler != null)
            {
                handler(sender, e);
            }
        }
        #endregion

        private void btnUserView_Click(object sender, EventArgs e)
        {
            var TutorForm = new AdminViewTutors();
            TutorForm.ShowDialog();
        }

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
        
    }
}
