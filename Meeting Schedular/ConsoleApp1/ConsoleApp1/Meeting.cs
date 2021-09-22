using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Meeting
    {
        public Guid Id { get; set; }
        public string Details { get; set; }
        public DateTime MeetingTime { get; set; }
        public int Duration { get; set; }
        public int MinAttendees { get; set; }
        public int MaxAttendees { get; set; }
    }
}
