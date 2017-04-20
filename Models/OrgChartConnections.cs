using System;
using System.Collections.Generic;

namespace Angular2Spa.Models
{
    public partial class OrgChartConnections
    {
        public int Id { get; set; }
        public int? FromShapeId { get; set; }
        public int? ToShapeId { get; set; }
        public string Text { get; set; }
        public int? FromPointX { get; set; }
        public int? FromPointY { get; set; }
        public int? ToPointX { get; set; }
        public int? ToPointY { get; set; }
    }
}
