using System;

namespace StockFighter.Api
{
    public static class Endpoints
    {
        public static T GetHeartbeat<T>(this IHeartbeatable topic)
        {
            var heartbeatUri = new Uri(topic.Uri + "/heartbeat");
            return JsonHttpHelper.GetDeserializedResponse<T>(heartbeatUri);
        }
    }
}