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
    public partial class ClientConfirm : Form
    {
        public ClientConfirm()
        {
            InitializeComponent();
            login1.loginEventHandler += this.login;
        }

        private void login(object sender, EventArgs e)
        {
            ExitEvent(login1.id);
            this.Close();
        }

        private void ClientConfirm_FormClosing(string blah)
        {
           
        }
        
        public EventHandler ExitEventHandler;
        public delegate void ExitEventHandlerDelegate(string id);

        public event ExitEventHandlerDelegate ExitEventDelegate;
        public void ExitEvent(string id)
        {
          //  EventHandler handler = ExitEventHandler;
            //if (handler != null)
            {
                ExitEventDelegate(id);
            }
        }


        //public EventHandler noShowEventHandler;
        //public delegate void noShowEventHandlerDelegate(string id);

        //public event noShowEventHandlerDelegate noShowEventDelegate;
        //public void noShowEvent(string id)
        //{

        //        noShowEventDelegate(id);

        //}

        private void btnNoShow_Click(object sender, EventArgs e)
        {
            ExitEvent("");
            this.Close();
        }
    }
}
