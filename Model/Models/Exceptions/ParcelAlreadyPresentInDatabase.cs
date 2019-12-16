using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Models.Exceptions
{
    public class ParcelAlreadyPresentInDatabase : Exception
    {
        public ParcelAlreadyPresentInDatabase(Parcel parcel) :
            base("Parcel " + parcel.ToString() + " already present in the database.\n")
        {

        }
    }
}
