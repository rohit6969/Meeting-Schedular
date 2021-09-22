using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Invitation
    {
        public Guid Id { get; set; }
        public Status Status { get; set; }
        public DateTime SentAt { get; set; }
        public DateTime RepliedAt { get; set; }
        public User Invitee { get; set; }
        public Meeting Meeting { get; set; }
    }

    public enum Status
    {
        Accepted,
        Rejected,
        Undecided
    }
}
