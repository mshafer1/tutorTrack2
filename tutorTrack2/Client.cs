using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tutorTrack2
{
    public class Client: User
    {
        private List<KeyValuePair<Course, string>> courses;
        public Client()
        {
            courses = new List<KeyValuePair<Course, string>>();
        }

        public void addCourse(KeyValuePair<Course, string> course)
        {
            if (!courses.Contains(course))
            {
                courses.Add(course);
            }
        }

        public void addCourse(Course course, string tutorName)
        {
            KeyValuePair<Course, string> coursePair = new KeyValuePair<Course, string>(course,tutorName);
            if (!courses.Contains(coursePair))
            {
                courses.Add(coursePair);
            }
        }

        public override userTypes getType()
        {
            return userTypes.Client;
        }
    }
}
