using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Moca.BFF.External
{
    public abstract class BaseHttpClient
    {
        private readonly HttpClient _httpClient;
        protected abstract string ServiceName { get; }

        public BaseHttpClient()
        {
            string baseUrl = "https://moca-rest-service.azurewebsites.net/api/";

            this._httpClient = new HttpClient()
            {
                BaseAddress = new Uri(baseUrl + ServiceName + "/")
            };
        }

        public async Task<T> ExecuteGetAsync<T>(string endpoint)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(endpoint);

            if (response.IsSuccessStatusCode)
            {
                var stringResult = await response.Content.ReadAsStringAsync();
                try
                {
                    var result = JsonConvert.DeserializeObject<T>(stringResult);
                    return result;
                }
                catch (Exception ex)
                {
                    
                throw new Exception("a");

                }
            }
            else
            {
                throw new Exception("a");
            }
        }
    }
}
