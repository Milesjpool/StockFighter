using System;
using System.Collections.Generic;

namespace StockFighter.Api.Responses
{
    public class Stock
    {
        public bool Ok { get; set; }
        public string Symbol { get; set; }
        public List<StockBid> Bids { get; set; }
        public List<StockBid> Asks { get; set; }
        public DateTime Ts { get; set; }
    }
}