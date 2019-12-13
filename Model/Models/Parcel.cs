namespace Model.Models
{
    public class Parcel
    {
        public string ID { get; set; }
        public int StorePlaceId { get; set; }
        public PersonalData SenderData { get; set; }
        public PersonalData ReceiverData { get; set; }
        public string ReferenceID { get; set; }

        public Parcel(PersonalData senderData, PersonalData receiverData)
        {
            SenderData = senderData;
            ReceiverData = receiverData;
        }

        public Parcel(PersonalData senderData, PersonalData receiverData, string referenceID)
        {
            SenderData = senderData;
            ReceiverData = receiverData;
            ReferenceID = referenceID;
        }
    }
}
