namespace Model.Models
{
    public class Vehicle
    {
        public int Id { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public string Registration { get; set; }

        public Employee Driver { get; set; }

        public Warehouse Warehouse { get; set; }
    }
}
