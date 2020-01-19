using System;
using System.Collections.Generic;
using System.Text;
using Model.Enums;

namespace Model.Models.Exceptions
{
    public class NewRouteInvalidDataException : Exception
    {
        public NewRouteInvalidDataException(Employee employee) :
            base("Invalid employee: " + employee.ToString())
        { }

        public NewRouteInvalidDataException(Vehicle vehicle) :
            base("Invalid vehicle: " + vehicle.ToString())
        { }

        public NewRouteInvalidDataException(Parcel parcel) :
            base("Invalid parcel: " + parcel.ToString())
        { }

        public NewRouteInvalidDataException(ParcelStatus parcelStatus) :
           base("Invalid parcel status: " + parcelStatus.ToString())
        { }
    }
}
