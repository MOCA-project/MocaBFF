using Moca.BFF.External.ExceptionHandler;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http.Json;

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
                catch (JsonSerializationException ex)
                {
                    throw new Exception($"Erro na desserialização JSON: {ex.Message}");
                }
            }
            else
            {
                HandleErrorResponse(response);
                return default;

            }
        }

        public async Task<T> ExecutePostAsync<T>(string endpoint, object content)
        {
            HttpResponseMessage response = await _httpClient.PostAsJsonAsync(endpoint, content);

            if (response.IsSuccessStatusCode)
            {
                var stringResult = await response.Content.ReadAsStringAsync();
                try
                {
                    var result = JsonConvert.DeserializeObject<T>(stringResult);
                    return result;
                }
                catch (JsonSerializationException ex)
                {
                    throw new Exception($"Erro na desserialização JSON: {ex.Message}");
                }
            }
            else
            {
                HandleErrorResponse(response);
                return default;
            }
        }

        public async Task<T> ExecutePutAsync<T>(string endpoint, object content)
        {
            HttpResponseMessage response = await _httpClient.PutAsJsonAsync(endpoint, content);

            if (response.IsSuccessStatusCode)
            {
                var stringResult = await response.Content.ReadAsStringAsync();
                try
                {
                    var result = JsonConvert.DeserializeObject<T>(stringResult);
                    return result;
                }
                catch (JsonSerializationException ex)
                {
                    throw new Exception($"Erro na desserialização JSON: {ex.Message}");
                }
            }
            else
            {
                HandleErrorResponse(response);
                return default;

            }
        }

        public async Task<T> ExecuteDeleteAsync<T>(string endpoint)
        {
            HttpResponseMessage response = await _httpClient.DeleteAsync(endpoint);

            if (response.IsSuccessStatusCode)
            {
                var stringResult = await response.Content.ReadAsStringAsync();
                try
                {
                    var result = JsonConvert.DeserializeObject<T>(stringResult);
                    return result;
                }
                catch (JsonSerializationException ex)
                {
                    throw new Exception($"Erro na desserialização JSON: {ex.Message}");
                }
            }
            else
            {
                HandleErrorResponse(response);
                return default;

            }
        }

        private static void HandleErrorResponse(HttpResponseMessage response)
        {
            if (response.StatusCode == HttpStatusCode.NotFound)
            {
                throw new BusinessException("Recurso não encontrado.", HttpStatusCode.NotFound);
            }
            else if (response.StatusCode == HttpStatusCode.BadRequest)
            {
                throw new BusinessException("Requisição inválida.", HttpStatusCode.BadRequest);
            }
            else
            {
                throw new BusinessException($"Erro na requisição: {response.StatusCode}", response.StatusCode);
            }
        }
    }
}
