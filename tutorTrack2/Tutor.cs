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
        private User current;
        public AVLTree<Client> clients;
        public AVLTree<Course> courses;

        public Tutor()
        {
            //courses = new AVLTree<Course>(); //new List<Course>();
        }

       // public static Tutor FindTutor(string input)
        //{
        //    var tutorList = singeltonTutorList.getInstance();
        //    foreach(var tutor in tutorList)
        //    {
        //        if (tutor.Name == input)
        //        {
        //            return tutor;
        //        }
        //    }
        //    throw new Exception();
        //}
        
        public Tutor(User current)
        { 
            this.current = current;
            if (current.getType() == userTypes.Tutor)
            {
                this.Id = current.Id;
                this.Name = current.Name;
            }
        }

        public override userTypes getType()
        {
            return userTypes.Tutor;
        }

        public void addCourse(Course newCourse)
        {
            //if (!courses.Contains(newCourse))
            //{
            //    courses.Add(newCourse);
            //}
        }

        //public void addClient(Client newClient)
        //{
        //    if (!clients.Contains(newClient))
        //    {
        //        clients.Add(newClient);
        //    }
        //}
    }
}
