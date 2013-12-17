using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorTrack2
{
    class User
    {
        private string idString, nameString;

        public string id
        {
            get { return this.idString; }
            set { this.idString = value; }
        }

        public string name
        {
            get { return this.nameString; }
            set { this.nameString = value; }
        }
    }
}
