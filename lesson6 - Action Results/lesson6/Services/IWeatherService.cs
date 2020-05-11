using lesson6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lesson6.Services
{
    public interface IWeatherService
    {
        Task<IWeather> GetWeatherAsync(string region = null);
    }
}
