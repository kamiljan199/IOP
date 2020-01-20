namespace Model.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public string Street { get; set; }
        public string HomeNumber { get; set; }
        public int? ApartmentNumber { get; set; }
    }
}
