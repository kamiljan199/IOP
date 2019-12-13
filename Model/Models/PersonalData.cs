namespace Model.Models
{
    public class PersonalData
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }

        public Address PersonalAddress { get; set; }
        public PersonalData(string firstName, string lastName, string phoneNumber, Address personalAddress)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            PersonalAddress = personalAddress;
            ValidatePersonalData();
        }

        public void ValidatePersonalData()
        {
            ValidatePhoneNumber();
        }

        private void ValidatePhoneNumber()
        {
            if(PhoneNumber.Length != 9)
            {
                throw new Exceptions.InvalidDataFormatException("phone number (Length != 9)");
            }
            for(int i = 0; i < 9; ++i)
            {
                if(PhoneNumber[i] < '0' && PhoneNumber[i] > '9')
                {
                    throw new Exceptions.InvalidDataFormatException( string.Format("phone number (Invalid character at {0})", i) );
                }
            }
        }
    }
}