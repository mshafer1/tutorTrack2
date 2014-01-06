using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorTrack2
{
    static class singletonAvailClassesList
    {
        static public List<Course> getInstance()
        {
            if (p == null)
            {
                p = new List<Course>();//key - id, value - name;
                var coursesList = (from tutor in singeltonTutorList.getInstance()
                                   select tutor.classes());

                foreach (Course course in (List<Course>)coursesList)
                {
                    if (!p.Contains(course))
                    {
                        p.Add(course);
                    }
                }
            }
            return p;
        }
        static List<Course> p;
    }
}
