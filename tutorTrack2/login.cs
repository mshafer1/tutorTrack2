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
    public partial class login : UserControl
    {
        public login()
        {
            InitializeComponent();
            IDField.PasswordChar = '*';
            idString = "";
            loginEventHandler += Login;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (IDField.Text.Length > 0
                && (IDField.Text[0] == ';' || (IDField.Text[0] == 'H' && IDField.Text.Length > 1 && char.IsDigit(IDField.Text[1])) 
                || (IDField.Text[0] == 'h' && IDField.Text.Length > 1 && char.IsDigit(IDField.Text[1]))))
            {
                if (IDField.Text[IDField.Text.Length - 1] == '?')
                {
                    idString = IDField.Text.Substring(1, IDField.Text.Length - 3);
                }
                else
                {
                    idString = IDField.Text.Substring(1);
                    if (idString.Length > 8)
                    {
                        idString = idString.Substring(0, 8);
                    }
                }
            }
            else
            {
                if (IDField.Text.Length > 0 && (char.IsLetter(IDField.Text[0]) && IDField.Text.Length > 1 && char.IsLetter(IDField.Text[1])))
                {
                    idString = IDField.Text;
                }
                else
                {
                    idString = IDField.Text.Substring(0, (IDField.Text.Length <= 8) ? IDField.Text.Length : 8);
                }
            }
        }

        private string idString;

        public string id
        {
            get { return this.idString; }
            //set { this.id = value; }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                LoginEvent(sender, e);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            LoginEvent(sender, e);
        }

        public EventHandler loginEventHandler;
        public delegate void loginEventHandlerDelegate(object sender, EventArgs e);
        public void LoginEvent(object sender, EventArgs e)
        {
            EventHandler handler = loginEventHandler;
            if (handler != null)
            {
                handler(sender, e);
            }
        }
        public void Login(object sender, EventArgs e = null)
        {
            this.Visible = false;
        }

        internal void Reset()
        {
            IDField.Text = "";
        }
    }
}
