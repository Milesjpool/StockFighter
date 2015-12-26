namespace StockFighter.Api.Responses
{
    public class VenueHeartbeat : IHeartbeat
    {
        public bool Ok { get; set; }
        public string Venue { get; set; }
    }
}