using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorTrack2
{
    public class Appointment
    {
        public string tutor { get; set; }
        public string client { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public bool finished { get; set; }
        public string course { get; set; }
        public bool noShow { get; set; }
    }
}
