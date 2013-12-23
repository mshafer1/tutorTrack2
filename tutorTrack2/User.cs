using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorTrack2
{
    public class User//: IComparable<User>
    {
        protected string idString, nameString;
        public string getid()
        {
            return idString;
        }
        public void setId(string input)
        {
            idString = input;
        }
        //public string id
        //{
        //    get { return this.idString; }
        //    set { this.idString = value; }
        //}
        public string getName()
        {
            return nameString;
        }
        public void setName(string input)
        {
            nameString = input;
        }
        //public string name
        //{
        //    get { return this.nameString; }
        //    set { this.nameString = value; }
        //}

        //public int CompareTo(User input)
        //{
        //    int result;

        //    if (input.idString == idString || input.idString == nameString)
        //    {
        //        result = 0;
        //    }
        //    else
        //    {
        //        result = string.Compare(input.idString, idString);
        //    }

        //    return result;
        //}
    }
}
