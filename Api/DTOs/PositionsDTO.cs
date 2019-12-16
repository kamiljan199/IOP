using System;
using System.Collections.Generic;
using System.Text;
using Api.Enums;
using Model.Models;
namespace Api.DTOs
{
    public class PositionsDTO
    {
        public List<Position> Positions { get; set; }
        public CollectionGetStatus Status;
    }
}
