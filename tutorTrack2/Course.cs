using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tutorTrack2
{
    public class Course: IComparable<Course>
    {
        public string commonName;
        public string idString;
        
        public Course(string p)
        {
            commonName = p;
        }
        public Course(Course p)
        {
            commonName = p.commonName;
            idString = p.idString;
        }
        public Course()
        {
            commonName = idString = "";
        }
        public string id
        {
            get { return this.idString; }
            set { this.idString = value; }
        }

        public string name
        {
            get { return this.commonName; }
            set { this.commonName = value; }
        }

        public int CompareTo(Course input)
        {
                return string.Compare(this.id, input.id);
        }
    }
}
