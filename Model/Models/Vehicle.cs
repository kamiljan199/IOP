namespace Model.Models
{
    public class Vehicle
    {
        public int Id { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public string Registration { get; set; }

        public int? DriverId { get; set; }
        public virtual Employee Driver { get; set; }

        public int? WarehouseId { get; set; }
        public virtual Warehouse Warehouse { get; set; }
    }
}
