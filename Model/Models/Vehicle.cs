namespace Model.Models
{
    public class Vehicle
    {
        public int Id { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public string Registration { get; set; }

        public float MaxCapacity { get; set; }

        public float MaxLoad { get; set; }

        public int? StorePlaceId { get; set; }
        public virtual StorePlace StorePlace{ get; set; }
    }
}
