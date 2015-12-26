using NUnit.Framework;
using StockFighter.Api;

namespace StockFighterTests
{
    [TestFixture]
    public class StockfighterApiTests
    {
        [Test]
        public void ApiIsAvailable()
        {
            var heartbeat = StockfighterApi.Heartbeat();
            Assert.That(heartbeat.Ok, Is.True, heartbeat.Error);
        }

        [Test]
        public void VenueIsAvailable()
        {
            const string testVenue = "TESTEX";
            var venueStatus = StockfighterApi.VenueHeartbeat(testVenue);
            Assert.That(venueStatus.Venue, Is.EqualTo(testVenue));
            Assert.That(venueStatus.Ok, Is.True);
        }
    }
}
