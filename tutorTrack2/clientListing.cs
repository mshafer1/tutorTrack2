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
    public partial class clientListing : UserControl
    {
        public clientListing()
        {
            InitializeComponent();
        }
        public void setTutor(Tutor input)
        {
            List<Tutor> tutors = singletonTutorList.getInstance();
            List<Client> clients = input.clients;
            if (clients != null)
            {
                lblClientNames.Text = "";
                lblClass.Text = "";
                lblEmail.Text = "";
                lblPhone.Text = "";
                foreach (Client c in clients)
                {
                    lblClientNames.Text += c.Name + "\n";
                    lblClass.Text += c.course.ToString() + "\n";
                    lblEmail.Text += c.contactInfo.email + "\n";
                    lblPhone.Text += c.contactInfo.phoneNumber + "\n";
                }
            }

        }
    }
}
