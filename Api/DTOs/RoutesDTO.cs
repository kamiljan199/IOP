using System;
using System.Collections.Generic;
using System.Text;
using Api.Enums;
using Model.Models;

namespace Api.DTOs
{
    public class RoutesDTO
    {
        public ICollection<Route> Routes { get; set; }
        public CollectionGetStatus Status;
    }
}
