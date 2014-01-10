using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SelfBalancedTree;

namespace tutorTrack2
{
    public class Tutor : User
    {
        //public string id, name;
        public Tutor()
        {
            courses = new AVLTree<Course>(); //new List<Course>();
           // clients = new Dictionary<string, Course>();
        }

        public Tutor(User current)
        {
            // TODO: Complete member initialization
            this.current = current;
        }

        public override userTypes getType()
        {
            return userTypes.Tutor;
        }
        public AVLTree<KeyValuePair<string,Course>> clients;//key = client name, value = course
        public AVLTree<Course> courses;
        private User current;
        public void addCourse(Course newCourse)
        {
           // if (!courses.Contains(newCourse))
            {
                courses.Add(newCourse);
            }
        }
        public List<Course> classes()
        {
            List<Course> result = new List<Course>();
            List<Course> courseList = courses.getList();

            foreach (var c in courseList)
            {
                if (!result.Contains(c))
                {
                    result.Add(c);
                }
            }
            return result;
        }
    }
}
