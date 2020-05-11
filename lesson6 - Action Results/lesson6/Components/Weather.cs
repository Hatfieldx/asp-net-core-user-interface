using lesson6.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lesson6.Components
{
    public class Weather : ViewComponent
    {
        private readonly OpenWeatherService _weather;

        public Weather(OpenWeatherService weather)
        {
            _weather = weather;
        }
        public async Task<IViewComponentResult> InvokeAsync(string region)
        {
            return View("", await _weather.GetWeatherAsync());
        }
    }
}
