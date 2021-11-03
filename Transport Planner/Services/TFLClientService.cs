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
        public ApiResponse GetLocations(string searchTerms)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri("https://api.tfl.gov.uk");
                    var response = client.GetAsync($"/Stoppoint/Search/{searchTerms}").Result;
                    response.EnsureSuccessStatusCode();

                    var stringResult =  response.Content.ReadAsStringAsync().Result;

                    var results = JsonConvert.DeserializeObject<ApiResponse>(stringResult);

                    return results;
                    

                }
                catch (HttpRequestException httpRequestException)
                {
                    throw httpRequestException;
                }
            }
        }
            
    }
}
