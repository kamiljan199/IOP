using System;
using System.Collections.Generic;

namespace Model.Models
{
    public class Route
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
        public int VehicleId { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        public DateTime CreationDateTime { get; set; }
        public virtual ICollection<RoutePoint> RoutePoints { get; set; }
    }
}
