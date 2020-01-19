using System.ComponentModel.DataAnnotations.Schema;
using Model.Enums;


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
        public float ParcelWeight { get; set; }
        public string ParcelType { get; set; }
        public int Priority { get; set; }
        public int ReferenceId { get; set; }
        public ParcelStatus ParcelStatus { get; set; }
        public int? CourierID { get; set; }
    }
}
