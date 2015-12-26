using System.Collections.Generic;

namespace StockFighter.Api.Responses
{
    public class VenueStocks
    {
        public bool Ok { set; get; }
        public List<Stock> Symbols { get; set; }
    }
}