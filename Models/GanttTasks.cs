using System;
using System.Collections.Generic;

namespace Angular2Spa.Models
{
    public partial class GanttTasks
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public int OrderId { get; set; }
        public string Title { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public decimal PercentComplete { get; set; }
        public bool Expanded { get; set; }
        public bool Summary { get; set; }

        public virtual GanttTasks Parent { get; set; }
        public virtual ICollection<GanttTasks> InverseParent { get; set; }
    }
}
