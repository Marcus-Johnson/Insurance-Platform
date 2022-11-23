using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Weather.ApiWrapper.Concrete;
using Weather.ApiWrapper.Interface;

namespace Weather.ApiWrapper
{
    public class WeatherApi
    {
        private readonly HttpClient _client;
        private readonly IWeatherParameters _weatherParameter;
        public WeatherApi()
        {
            this._weatherParameter = new WeatherParameter();
            this._client = new HttpClient();
            this._client.DefaultRequestHeaders.Clear();
            this._client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            this._client.BaseAddress = new Uri(this._weatherParameter.URL);
        }

        public async Task<string> GetResult()
        {
            string result = string.Empty;

            using (this._client)
            {
                var httpResponse = await this._client.GetAsync(this._weatherParameter.GetUri(), 
                        HttpCompletionOption.ResponseContentRead);

                httpResponse.EnsureSuccessStatusCode();

                if (httpResponse.Content.Headers.ContentType?.MediaType == "application/json")
                {
                    result = await httpResponse.Content.ReadAsStringAsync();
                }
            }

            return result;
        }
    }
}
