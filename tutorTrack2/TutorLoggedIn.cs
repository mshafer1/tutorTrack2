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
    public partial class TutorLoggedIn : UserControl
    {
        Tutor current;
        public TutorLoggedIn()
        {
            InitializeComponent();
        }

        public void setTutor(Tutor input)
        {
            current = input;
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            //show window with client information.
            ClientListDisplayForm clientForm1 = new ClientListDisplayForm();
            clientForm1.clientListing1.display(current);
            clientForm1.ShowDialog();
        }
        
        private void btnAppointment_Click(object sender, EventArgs e)
        {

        }
    }
}
