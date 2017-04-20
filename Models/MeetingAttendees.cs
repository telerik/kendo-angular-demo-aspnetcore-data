using System;
using System.Collections.Generic;

namespace Angular2Spa.Models
{
    public partial class MeetingAttendees
    {
        public int MeetingId { get; set; }
        public int AttendeeId { get; set; }

        public virtual Meetings Meeting { get; set; }
    }
}
