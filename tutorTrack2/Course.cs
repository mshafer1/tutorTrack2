using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tutorTrack2
{
    public class Course
    {
        
        public Course(string p)
        {
            Name = p;
        }
        public Course(Course p)
        {
            Name = p.Name;
            Id = p.Id;
        }
        public Course()
        {
            Name = Id = "";
        }
        public string Name { get; set; }
        public string Id { get; set; }

        //public override int CompareTo(Course input)
        //{
        //    return string.Compare(this.id, input.id);
        //}

        public override string ToString()
        {
            string result = "";
            if (Id.Length > 0)
            {
                result += Id + ", ";
            }
            result += Name;

            return result;
        }

        public static Course FromString(string input)
        {
            Course result = new Course();
            result.Id = input.Substring(0, input.IndexOf(','));
            result.Name = input.Substring(input.IndexOf(',') + 1);
            return result;
        }
    }
}
