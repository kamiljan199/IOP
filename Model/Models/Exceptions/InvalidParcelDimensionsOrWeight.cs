using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Models.Exceptions
{
    public class InvalidParcelDimensionsOrWeight : Exception
    {
        public InvalidParcelDimensionsOrWeight(Parcel parcel)
            : base("Parcel dimensions: " + parcel.ParcelWidth + "x" + 
                  parcel.ParcelLength + "x" + 
                  parcel.ParcelHeight + " or weight: " + 
                  parcel.ParcelWeight + " are invalid!")
        {

        }
    }
}
