using System;

namespace Model.Models.Exceptions
{
    public class InvalidDataFormatException : Exception
    {
        public InvalidDataFormatException(string dataType) :
            base(String.Format("Invalid data format on {0}", dataType))
        {

        }
    }
}