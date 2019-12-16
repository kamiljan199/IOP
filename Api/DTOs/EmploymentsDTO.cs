using System;
using System.Collections.Generic;
using System.Text;
using Model.Models;
using Api.Enums;

namespace Api.DTOs
{
    public class EmploymentsDTO
    {
        public List<Employment> Employments { get; set; }
        public CollectionGetStatus Status;
    }
}
