using System;
using System.Collections.Generic;

namespace Angular2Spa.Models
{
    public partial class GanttDependencies
    {
        public int Id { get; set; }
        public int PredecessorId { get; set; }
        public int SuccessorId { get; set; }
        public int Type { get; set; }
    }
}
