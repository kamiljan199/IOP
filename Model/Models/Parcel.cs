namespace Model.Models
{
    public class Parcel
    {
        public int Id { get; set; }
        public int StorePlaceId { get; set; }
        public PersonalData SenderData { get; set; }
        public PersonalData ReceiverData { get; set; }
        public string ReferenceId { get; set; }
    }
}
