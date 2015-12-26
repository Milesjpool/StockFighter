using System;

namespace StockFighter.Api
{
    public class StockfighterApi : IHeartbeatable
    {
        public Uri Uri { get; set; }

        public StockfighterApi()
        {
            Uri = new Uri("https://api.stockfighter.io/ob/api");
        }

        public Venue Venue(string venue)
        {
            return new Venue(Uri, venue);
        }
    }
}