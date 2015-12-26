using System;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace StockFighter.Api
{
    public static class JsonHttpHelper
    {
        public static T GetDeserializedResponse<T>(Uri uri)
        {
            var webRequest = WebRequest.Create(uri);
            webRequest.Timeout = 2000;
            using (var response = webRequest.GetResponse())
            {
                using (var streamReader = new StreamReader(response.GetResponseStream()))
                {
                    var responseBody = streamReader.ReadToEnd();
                    return JsonConvert.DeserializeObject<T>(responseBody);
                }
            }
        }
    }
}