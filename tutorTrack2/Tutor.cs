using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorTrack2
{
    class Tutor : User, IDisposable, IComparable<Tutor>
    {
        void System.IDisposable.Dispose()
        {
        }

        public int CompareTo(Tutor input)
        {
            int result;// = 0;

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
