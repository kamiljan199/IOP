namespace Model.Models
{
    public class PersonalData
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public virtual Address PersonalAddress { get; set; }
    }
}