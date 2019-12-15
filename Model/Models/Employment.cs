using System;

namespace Model.Models
{
    public class Employment
    {
        public int Id { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public float Salary { get; set; }

        public Position Position { get; set; }

        public Warehouse Warehouse { get; set; }
    }
}
