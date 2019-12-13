namespace Model.Models
{
    public class Package
    {
        public int Id { get; set; }
        public int StorePlaceId { get; set; }
        public string SenderName { get; set; }
        public Address SenderAddress { get; set; }
        public string ReceiverName { get; set; }
        public Address ReceiverAddress { get; set; }
    }
}
