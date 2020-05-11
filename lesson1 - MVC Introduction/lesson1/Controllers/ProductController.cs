using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using lesson1.Models;
using lesson1.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace lesson1.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductsService _products;
        private readonly IWebHostEnvironment _env;

        public ProductController(ProductsService productsService, IWebHostEnvironment env)
        {
            _products = productsService;
            _env = env;
        }

        public async Task<IActionResult> List(string category)
        {
            IEnumerable<Product> products = await _products.GetProductsAsync();

            if (!string.IsNullOrEmpty(category))
            {
                products = products.Where(x => x.Category == category);
            }

            return View(products);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (!id.HasValue)            
                return BadRequest("Неверный идентификатор товара");             
            
            IEnumerable<Product> products = await _products.GetProductsAsync();

            return View(products.FirstOrDefault(product => product.Id == id.Value));
        }
        
        public IActionResult GetFile()
        {
            string path = @"D:\My Downloads\Видео\ITVDN\.Net, MVC, Core, WPF, UWP\.Net Developer\Создание пользовательского интерфейса в ASP.NET Core\Lesson 1. MVC Introduction\001. Introduction.pdf";

            return PhysicalFile(path, "application/pdf", "lesson_1");

        }
        public IActionResult GetDataFile()
        {
            return PhysicalFile(Path.Combine(_env.ContentRootPath, "App_Data", "data.txt"), "text/plain", "data");
        }
    }
}