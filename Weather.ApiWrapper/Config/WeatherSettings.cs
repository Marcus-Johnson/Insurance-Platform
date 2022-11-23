using Microsoft.Extensions.Configuration;
using System.IO;
using System.Linq;

namespace Weather.ApiWrapper.Config
{
    public static class WeatherSettings
    {
        private static readonly IConfiguration Configuration;

        /// <summary>
        /// Builds the configuration that we need to read
        /// </summary>
        static WeatherSettings()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appSettings.json", optional: false, reloadOnChange: true);
            
            Configuration = builder.Build();
        }

        /// <summary>
        /// This method helps us to get the value of the section we need to read on our JSON configuration.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="isArray"></param>
        /// <returns></returns>
        public static string Get(string name, bool isArray = false)
        {
            string appSettings;

            if (isArray)
            {
                var result = Configuration
                                        .GetSection($"WeatherSettings:{name}")
                                        .GetChildren().Select(item => item.Value).ToArray();

                appSettings = string.Join(",", result);
            }
            else
            {
                appSettings = Configuration[$"WeatherSettings:{name}"];
            }
               
            return appSettings;
        }
    }
}
