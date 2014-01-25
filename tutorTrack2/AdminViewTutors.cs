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
    public partial class AdminViewTutors : Form
    {
        public AdminViewTutors()
        {
            InitializeComponent();
        }
        bool ready;
        private void AdminViewTutors_Load(object sender, EventArgs e)
        {
            ready = false;
            listBox1.DataSource = singletonTutorList.getInstance();
            ready = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ready)
            {
                Tutor temp = Tutor.FindTutor(listBox1.SelectedValue.ToString());
                tutorCourseList1.setTutor(temp);
                clientListing1.setTutor(temp);
                listBox1.Visible = false;
                tutorCourseList1.Visible = true;
                clientListing1.Visible = true;
            }
        }

        private void btnFinished_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
