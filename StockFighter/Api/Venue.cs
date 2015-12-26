using System;
using StockFighter.Api.Responses;

namespace StockFighter.Api
{
    public class Venue : IHeartbeatable
    {
        public Uri Uri { get; set; }

        public Venue(Uri apiBase, string venue)
        {
            Uri = new Uri(apiBase + "/venues/" + venue);
        }

        public VenueStocks GetStocks()
        {
            var heartbeatUri = new Uri(Uri + "/stocks");
            return JsonHttpHelper.GetDeserializedResponse<VenueStocks>(heartbeatUri);
        }

        public Stock GetStock(string symbol)
        {
            var heartbeatUri = new Uri(Uri + "/stocks/" + symbol);
            return JsonHttpHelper.GetDeserializedResponse<Stock>(heartbeatUri);
        }
    }
}