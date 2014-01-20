using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tutorTrack2
{
    public class Client: User
    {
        public Client(string name, string id)
        {
            ContactInfoForm current = new ContactInfoForm();
            current.ShowDialog();
            contactInfo = current.contactInfo;
            this.Name = name;
            this.Id = id;
        }

        public Client(ContactInfo input)
        {
            contactInfo = input;
        }

        public Client()
        {
        }
        internal ContactInfo contactInfo { get; set; }

        internal Course course { get; set; }

        public Tutor tutor { get; set; }

        

        public override userTypes getType()
        {
            return userTypes.Client;
        }
    }
}
