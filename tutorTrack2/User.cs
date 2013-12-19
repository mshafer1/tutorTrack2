using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorTrack2
{
    public class User: IComparable<User>
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

        public int CompareTo(User input)
        {
            int result;

            if (input.id == id || input.id == name)
            {
                result = 0;
            }
            else
            {
                result = string.Compare(input.id, id);
            }

            return result;
        }
    }
}
