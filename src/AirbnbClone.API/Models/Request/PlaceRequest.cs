namespace AirbnbClone.API.Models.Request
{
    public class PlaceRequest
    {
        public int Limit { get; set; }
        public int Page  { get; set; }
        public string Sort { get; set; }
        public int Direction { get; set; }
    }
}