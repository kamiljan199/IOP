using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Models.Exceptions
{
    public class NothingAddedToDatabaseException : Exception
    {
        public NothingAddedToDatabaseException(Parcel parcel) :
            base("Parcel " + parcel.ToString() + " was not succesfully added to the database.\n")
        {

        }
    }
}
