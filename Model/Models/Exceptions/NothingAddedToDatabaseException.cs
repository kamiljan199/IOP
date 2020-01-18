using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Models.Exceptions
{
    public class NothingAddedToDatabaseException : Exception
    {
        public NothingAddedToDatabaseException(Parcel parcel) :
            base("Parcel " + parcel.ToString() + " was not succesfully added to the database.\n")
        {}

        public NothingAddedToDatabaseException(Route route) :
            base("Route " + route.ToString() + " was not succesfully added to the database.\n")
        { }

        public NothingAddedToDatabaseException(RoutePoint[] routePoints) :
           base("RoutePoints " + routePoints.ToString() + " were not succesfully added to the database.\n")
        { }
    }
}
