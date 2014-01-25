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
    public partial class ContactInfoForm : Form
    {
        internal ContactInfo contactInfo { get; set; }
        public ContactInfoForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txbEmail.Text.Length > 0 || txbPhone.Text.Length > 0)
            {
                contactInfo = new ContactInfo();
                contactInfo.phoneNumber = txbPhone.Text;
                contactInfo.email = txbEmail.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("Must enter at least either a phone number or email address", "Error");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            contactInfo = null;
            this.Close();
        }
    }
}
