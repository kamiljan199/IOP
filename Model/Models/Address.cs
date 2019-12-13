namespace Model.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public string Street { get; set; }
        public string HomeNumber { get; set; }
        public int ApartmentNumber { get; set; }

        public Address(string city, string postCode, string street, string homeNumber)
        {
            City = city;
            PostCode = postCode;
            Street = street;
            HomeNumber = homeNumber;
            ValidateAddress();
        }

        public Address(string city, string postCode, string street, string homeNumber, int apartmentNumber)
        {
            City = city;
            PostCode = postCode;
            Street = street;
            HomeNumber = homeNumber;
            ApartmentNumber = apartmentNumber;
            ValidateAddress();
        }

        public void ValidateAddress()
        {
            ValidatePostCode();
            ValidateHomeNumber();
        }

        private void ValidateHomeNumber()
        {
            if(HomeNumber.Length < 1)
            {
                throw new Exceptions.InvalidDataFormatException("home number (too short or null)");
            }
            else if(HomeNumber[0] < '0' && HomeNumber[0] > '9')
            {
                throw new Exceptions.InvalidDataFormatException("home number (Invalid first char - it should be a number)");
            }
        }

        private void ValidatePostCode()
        {
            if(PostCode.Length != 6)
            {
                throw new Exceptions.InvalidDataFormatException("post code (Length != 6)");
            }
            for(int i = 0; i < 6; ++i)
            {
                if(i == 2 && PostCode[i] != '-')
                {
                    throw new Exceptions.InvalidDataFormatException("post code (Invalid format)");
                }
                else if(PostCode[i] < '0' && PostCode[i] > '9')
                {
                    throw new Exceptions.InvalidDataFormatException("post code (Invalid format)");
                }
            }
        }
    }
}
