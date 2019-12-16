using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Models.Exceptions
{
    public class ParcelNotFoundInDatabase : Exception
    {
        public ParcelNotFoundInDatabase(Parcel parcel) :
            base("Parcel " + parcel.ToString() + " not found in the database.\n")
        {

        }
    }
}
