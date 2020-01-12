using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Models
{
    public class Parcel
    {
        public int Id { get; set; }
        public int StorePlaceId { get; set; }
        public PersonalData SenderData { get; set; }
        public PersonalData ReceiverData { get; set; }
        public float ParcelWidth { get; set; }
        public float ParcelHeight { get; set; }
        public float ParcelLength { get; set; }
        public string ParcelType { get; set; }
        public int ReferenceId { get; set; }
        public bool IsDelivered { get; set; }
    }
}
