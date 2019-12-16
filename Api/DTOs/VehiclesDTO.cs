using System;
using System.Collections.Generic;
using System.Text;
using Model.Models;
using Api.Enums;

namespace Api.DTOs
{
    public class VehiclesDTO
    {
        public List<Vehicle> Vehicles { get; set; }
        public CollectionGetStatus Status;
    }
}
