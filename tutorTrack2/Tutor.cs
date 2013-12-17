using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorTrack2
{
    class Tutor : User, IDisposable, /*IComparable<Tutor>,*/ IEquatable<Tutor>
    {
        void System.IDisposable.Dispose()
        {
        }
        public override int GetHashCode()
        {
            return System.Convert.ToInt16(id);
        }
        private List<Course> courses;
        public void addCourse(Course newCourse)
        {
            if (!courses.Contains(newCourse))
            {
                courses.Add(newCourse);
            }
        }
        public List<Course> classes()
        {
            List<Course> result = new List<Course>();
            foreach (var c in courses)
            {
                if (!result.Contains(c))
                {
                    result.Add(c);
                }
            }
            return result;
        }
        //public int CompareTo(Tutor input)
        //{
        //    int result;// = 0;

        //    if (input.id == id || input.id == name)
        //    {
        //        result = 0;
        //    }
        //    else
        //    {
        //        result = string.Compare(input.id, id);
        //    }

        //    return result;
        //}
       
        //  bool System.IEquatable<object>.Equals(object input)
        //{
        //    bool result;// = 0;

        //    if (input == this)
        //    {
        //        result = true;
        //    }
        //    else
        //    {
        //        result = false;
        //    }

        //    return result;
        //}

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Tutor objAsTutor = obj as Tutor;
            if (objAsTutor == null) return false;
            else return Equals(objAsTutor);
        }

        public bool Equals(Tutor other)
        {
            if (other == null)
            {
                return false;
            }
            return (id == other.id);
        }
    }
}
