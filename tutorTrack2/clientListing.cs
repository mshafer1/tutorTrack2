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
        public void display( Tutor input )
        {
            List<Tutor> tutors = singeltonTutorList.getInstance();
            /*var ClientNames = from client in (from tutor in tutors
                               where tutor == input
                               select tutor.clients)
                                  select client.Keys;
            lblClientNames.Text = ClientNames.ToString();*/
        }
    }
}
