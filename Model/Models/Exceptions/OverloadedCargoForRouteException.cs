using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Models.Exceptions
{
    public class OverloadedCargoForRouteException : Exception
    {
        public OverloadedCargoForRouteException() :
           base("Car is overloaded.")
        { }
    }
}
