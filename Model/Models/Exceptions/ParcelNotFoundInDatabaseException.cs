using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Models.Exceptions
{
    public class ParcelNotFoundInDatabaseException : Exception
    {
        public ParcelNotFoundInDatabaseException() :
            base("Parcels not found in database.\n")
        {

        }

        public ParcelNotFoundInDatabaseException(Parcel parcel) :
            base("Parcel " + parcel.ToString() + " not found in the database.\n")
        {

        }

        public ParcelNotFoundInDatabaseException(int id) :
            base("Parcel with id " + id + " not found in the database.\n")
        {

        }

        public ParcelNotFoundInDatabaseException(StorePlace store) :
            base("Parcel from store place" + store.Name +  "not found in the database.\n")
        {

        }
    }
}
