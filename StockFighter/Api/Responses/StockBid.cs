namespace StockFighter.Api.Responses
{
    public class StockBid
    {
        public int Price { get; set; }
        public int Qty { get; set; }
        public bool IsBuy { get; set; }
    }
}