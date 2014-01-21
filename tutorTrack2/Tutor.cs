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
        public List<Client> clients;
        public List<Course> courses;

        public Tutor()
        {
            courses = new List<Course>(); //new List<Course>();
        }

        public static Tutor FindTutor(string input)
        {
            Tutor result =  singletonTutorList.getInstance().Find(x=>x.Name == input);
            if (result != null)
            {
                return result;
            }
            throw new Exception(); // this should never happen
        }

        public Tutor(User current)
        {
                this.Id = current.Id;
                this.Name = current.Name;
        }

        public override userTypes getType()
        {
            return userTypes.Tutor;
        }

        public void addCourse(Course newCourse)
        {
            if (!courses.Contains(newCourse))
            {
                courses.Add(newCourse);
            }
        }

        public void addClient(Client newClient)
        {
            if (clients == null)
            {
                clients = new List<Client>();
            }
            if (!clients.Contains(newClient))
            {
                clients.Add(newClient);
            }
        }

        public override string ToString()
        {
            return (Name);
        }
    }
}
