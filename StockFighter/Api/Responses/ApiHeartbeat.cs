namespace StockFighter.Api.Responses
{
    public class ApiHeartbeat : IHeartbeat
    {
        public bool Ok { get; set; }
        public string Error { get; set; }
    }
}