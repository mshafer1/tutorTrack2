using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tutorTrack2
{
    public class Course: IComparable<Course>
    {
        string commonName;
        string idString;
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
            int result;
            result = string.Compare(input.commonName, commonName);
            if (result != 0)
            {
                result = string.Compare(input.idString, idString);
            }
            return result;
        }

    }
}
