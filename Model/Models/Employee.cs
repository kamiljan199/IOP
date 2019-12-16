using System;

namespace Model.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Pesel { get; set; }

        public DateTime Birthday { get; set; }

        public Employment ActiveEmployment { get; set; }
    }
}
