using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using lesson8.Models;
using System.Text;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace lesson8.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var products = new List<string> { "Основы", "JavaScript", "C#", "Java", "Python" };


            ViewBag.Products = new SelectList(products, products[2]);

            //string[] source = { "Item 1", "Item 2", "Item 3", "Item 4", "Item 5" };
            //SelectList selectList = new SelectList(source, source[2]);
            //ViewBag.SelectItems = selectList;

            return View();
        }

        [HttpPost]
        public IActionResult Index(RegistrationModel model)
        {
            if (ModelState.IsValid)
            {
                return Json(model);
            }

            return View(model);
        }
    }
}