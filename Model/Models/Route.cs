using System;
using System.Collections.Generic;

namespace Model.Models
{
    public class Route
    {
        public int Id { get; set; }
        public Employee Employee { get; set; }
        public Vehicle Vehicle { get; set; }
        public DateTime CreationDateTime { get; set; }
        public virtual ICollection<RoutePoint> RoutePoints { get; set; }
    }
}
