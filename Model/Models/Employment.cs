using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Models
{
    public class Employment
    {
        public int Id { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public float Salary { get; set; }

        public bool IsActive { get; set; }

        public int PositionId { get; set; }
        public virtual Position Position { get; set; }

        public int WarehouseId { get; set; }
        public virtual Warehouse Warehouse { get; set; }

        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
