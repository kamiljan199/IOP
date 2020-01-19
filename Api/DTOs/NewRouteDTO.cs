using System;
using System.Collections.Generic;
using System.Text;
using Model.Models;
using Api.Enums;

namespace Api.DTOs
{
    public class NewRouteDTO
    {
        public Route Route;
        public NewRouteStatus Status;
        public string ErrorMessage;
    }
}
