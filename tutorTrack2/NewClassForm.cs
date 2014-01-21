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
    public partial class NewClassForm : Form
    {
        public NewClassForm()
        {
            InitializeComponent();
            newClass = false;
        }
        public bool newClass;
        public string name, id;
        private void btnCancel_Click(object sender, EventArgs e)
        {
            newClass = false;
            this.Close();
        }

        private void NewClassForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (newClass1.txbId.Text.Length > 0 && newClass1.txbName.Text.Length > 0)
            {
                newClass = true;
                name = newClass1.txbName.Text;
                id = newClass1.txbId.Text;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (newClass1.txbId.Text.Length > 0 && newClass1.txbName.Text.Length > 0)
            {
                newClass = true;
                name = newClass1.txbName.Text;
                id = newClass1.txbId.Text;

                List<Course>courses = singletonCourseList.getInstance();
                Course current = new Course();
                current.Name = name;
                current.Id = id;
                if(!courses.Contains(current))
                {
                    courses.Add(current);
                    singletonCourseList.saveToFile();
                }
                this.Close();
            }
            else
            {
                if (newClass1.txbName.Text.Length == 0)
                {
                    newClass1.txbName.Text = "Must enter a course name";
                }
                if (newClass1.txbId.Text.Length == 0)
                {
                    newClass1.txbId.Text = "Must enter a course ID";
                }
            }
            
        }
    }
}
