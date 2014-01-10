using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorTrack2
{
    public class User
    {
        private string id, name;

        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public virtual userTypes getType()
        {
            return userTypes.User;
        }
    }
}
