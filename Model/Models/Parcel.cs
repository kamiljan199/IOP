using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Models
{
    public class Parcel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int StorePlaceId { get; set; }
        public PersonalData SenderData { get; set; }
        public PersonalData ReceiverData { get; set; }
        public int ReferenceId { get; set; }


        public Parcel(int storePlaceId, PersonalData senderData, PersonalData recieverData, int referenceId)
        {
            StorePlaceId = storePlaceId;
            SenderData = senderData;
            ReceiverData = recieverData;
            ReferenceId = referenceId;
        }
    }
}
