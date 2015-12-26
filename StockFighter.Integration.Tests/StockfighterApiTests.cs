using System.Linq;
using NUnit.Framework;
using StockFighter.Api;
using StockFighter.Api.Responses;

namespace StockFighterTests
{
    [TestFixture]
    public class StockfighterApiTests
    {
        private StockfighterApi _stockfighterApi;

        [SetUp]
        public void SetUp()
        {
            _stockfighterApi = new StockfighterApi();
        }

        [Test]
        public void ApiIsAvailable()
        {
            var heartbeat = _stockfighterApi.GetHeartbeat<ApiHeartbeat>();
            Assert.That(heartbeat.Ok, Is.True, heartbeat.Error);
        }

        [Test]
        public void VenueIsAvailable()
        {
            const string testVenue = "TESTEX";
            var venueStatus = _stockfighterApi.Venue(testVenue).GetHeartbeat<VenueHeartbeat>();
            Assert.That(venueStatus.Ok, Is.True);
            Assert.That(venueStatus.Venue, Is.EqualTo(testVenue));
        }

        [Test]
        public void CanGetStocksFromAVenue()
        {
            const string testVenue = "TESTEX";
            var venueStocks = _stockfighterApi.Venue(testVenue).GetStocks();
            Assert.That(venueStocks.Ok, Is.True);
            Assert.That(venueStocks.Symbols.Count, Is.EqualTo(1));
            Assert.That(venueStocks.Symbols.Single().Symbol, Is.EqualTo("FOOBAR"));
        }

        [Test]
        public void CanGetOrderbookForStock()
        {
            const string testVenue = "TESTEX";
            const string symbol = "FOOBAR";
            var stock = _stockfighterApi.Venue(testVenue).GetStock(symbol);
            Assert.That(stock.Ok, Is.True);
            Assert.That(stock.Bids.Count, Is.GreaterThanOrEqualTo(0));
            Assert.That(stock.Asks.Count, Is.GreaterThanOrEqualTo(0));
        }
    }
}
