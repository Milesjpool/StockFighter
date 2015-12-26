using System;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using StockFighter.Api.Responses;

namespace StockFighter.Api
{
    public static class StockfighterApi
    {
        public static ApiHeartbeat Heartbeat()
        {
            var uri = new Uri("https://api.stockfighter.io/ob/api/heartbeat");
            var webRequest = WebRequest.Create(uri);
            webRequest.Timeout = 2000;
            using (var response = webRequest.GetResponse())
            {
                using (var streamReader = new StreamReader(response.GetResponseStream()))
                {
                    var responseBody = streamReader.ReadToEnd();
                    return JsonConvert.DeserializeObject<ApiHeartbeat>(responseBody);
                }
            }
        }

        public static VenueHeartbeat VenueHeartbeat(string venue)
        {
            var uri = new Uri("https://api.stockfighter.io/ob/api/venues/"+venue+"/heartbeat");
            var webRequest = WebRequest.Create(uri);
            webRequest.Timeout = 2000;
            using (var response = webRequest.GetResponse())
            {
                using (var streamReader = new StreamReader(response.GetResponseStream()))
                {
                    var responseBody = streamReader.ReadToEnd();
                    return JsonConvert.DeserializeObject<VenueHeartbeat>(responseBody);
                }
            }
        }
    }
}