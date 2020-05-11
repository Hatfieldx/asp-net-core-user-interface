using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using lesson6.Models;
using Microsoft.Extensions.Options;
using lesson6.Services;

namespace lesson6.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Product> _products;
        private readonly IWeatherService _weatherService;

        public HomeController(IWeatherService weatherService)
        {
            _weatherService = weatherService;

           // wetherService.GetWeather();

            var products = new List<Product>();
            
            for (int i = 0; i < 10; i++)
            {
                products.Add(new Product {Id = i, Name = $"Product name{i}", Price = i*5 });
            }

            _products = products;
        }
        public async Task<IActionResult> Index()
        {
            var weather = await _weatherService.GetWeatherAsync();

            ViewData["Weather"] = weather.Temp;

            return View();
        }
    }
}