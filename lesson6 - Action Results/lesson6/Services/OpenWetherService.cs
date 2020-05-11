using lesson6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using System.Net;
using System.IO;
using System.Text.Json;
using System.Text;

namespace lesson6.Services
{
    public class OpenWeatherService : IWeatherService
    {
        private readonly OpenWeatherSettings _weatherServiceSettings;

        const double kelvin = 273.15;

        public OpenWeatherService(IOptions<OpenWeatherSettings> options) => _weatherServiceSettings = options.Value;
        public async Task<IWeather> GetWeatherAsync(string region = null)
        {
            region = region ?? _weatherServiceSettings.Region;

            Weather weather = new Weather() {Region = region };
            
            string site = $"https://{_weatherServiceSettings.Host}/{_weatherServiceSettings.Method}?q={region}&apikey={_weatherServiceSettings.Apikey}";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(site);

            HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync();

            using (Stream stream = response.GetResponseStream())
                using (JsonDocument doc = await JsonDocument.ParseAsync(stream))
                    {
                        JsonElement el = doc.RootElement.GetProperty("main")
                                                         .GetProperty("temp");

                        if (el.TryGetDouble(out double temp))
                    weather.Temp = (int)(temp - kelvin);

                        return weather;
                    }
        }
    }
}
