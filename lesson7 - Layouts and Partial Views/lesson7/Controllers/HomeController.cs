using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using lesson7.Models;
using Microsoft.AspNetCore.Mvc;

namespace lesson7.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public void Index(CustomModel model)
        {
            Debug.WriteLine(model.First);
            Debug.WriteLine(model.Second);
            Debug.WriteLine(model.Count.ToString());
        }
    }
}