using System;
using System.Collections.Generic;
using System.Text;
using Api.Enums;
using Model.Models;

namespace Api.DTOs
{
    public class EmployeesDTO
    {
        public ICollection<Employee> Employees { get; set; }
        public CollectionGetStatus Status;
    }
}
