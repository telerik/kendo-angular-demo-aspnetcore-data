using System;
using System.Collections.Generic;

namespace Angular2Spa.Models
{
    public partial class Meetings
    {
        public Meetings()
        {
            MeetingAttendees = new HashSet<MeetingAttendees>();
        }

        public int MeetingId { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? RoomId { get; set; }
        public bool IsAllDay { get; set; }
        public string RecurrenceRule { get; set; }
        public int? RecurrenceId { get; set; }
        public string RecurrenceException { get; set; }
        public string StartTimezone { get; set; }
        public string EndTimezone { get; set; }

        public virtual ICollection<MeetingAttendees> MeetingAttendees { get; set; }
        public virtual Meetings Recurrence { get; set; }
        public virtual ICollection<Meetings> InverseRecurrence { get; set; }
    }
}
