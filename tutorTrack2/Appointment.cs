using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorTrack2
{
    class Appointment
    {
        internal Tutor tutor { get; set; }
        internal Client client { get; set; }
        internal DateTime startTime { get; set; }
        internal DateTime endTime { get; set; }
        internal bool finished { get; set; }
    }
}
