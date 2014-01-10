using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorTrack2
{
    public class AdminUser:User
    {
        private User current;

        public AdminUser(User current)
        {
            // TODO: Complete member initialization
            this.current = current;
        }

        public AdminUser()
        {
            Id = Name = "";
        }

        public override userTypes getType()
        {
            return userTypes.Admin;
        }
    }
}
