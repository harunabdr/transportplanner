using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Transport_Planner.Models;

namespace Transport_Planner.Services
{
    public class TFLClientService
    {
        public ApiGeolocationResponse GetLocations(string searchTerms)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    //calling API with user input in variable searchTerms

                    client.BaseAddress = new Uri("https://api.tfl.gov.uk");
                    var response = client.GetAsync($"/Stoppoint/Search/{searchTerms}?app_key=daab2828b18b4613a8b7b0ceec1b2770").Result;
                    response.EnsureSuccessStatusCode();

                    var stringResult =  response.Content.ReadAsStringAsync().Result;


                    //deserialise JSON response into ApiResponse class

                    var results = JsonConvert.DeserializeObject<ApiGeolocationResponse>(stringResult);

                    return results;
                    

                }
                //error handling

                catch (HttpRequestException httpRequestException)
                {
                    throw httpRequestException;
                }
            }
        }

        public ApiSearchResults GetJourney(string fromPoint, string toPoint)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri("https://api.tfl.gov.uk");
                    var response = client.GetAsync($"/journey/journeyresults/{fromPoint}/to/{toPoint}?app_key=daab2828b18b4613a8b7b0ceec1b2770").Result;
                    response.EnsureSuccessStatusCode();

                    var stringResult = response.Content.ReadAsStringAsync().Result;

                    var results = JsonConvert.DeserializeObject<ApiSearchResults>(stringResult);

                    return results;


                }
                catch (Exception httpRequestException)
                {
                    throw httpRequestException;
                }
            }
        }

    }
}
