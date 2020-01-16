namespace Model.Models
{
    public class RoutePoint
    {
        public int RouteId { get; set; }
        public virtual Route Route { get; set; }
        public Parcel Parcel { get; set; }
        public int Index { get; set; }
    }
}
