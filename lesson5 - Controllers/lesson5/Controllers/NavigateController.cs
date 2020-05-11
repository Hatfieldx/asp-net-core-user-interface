using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace lesson5.Controllers
{
    public class NavigateController : Controller
    {
        public IActionResult Main()
        {
            return View();
        }
        public IActionResult Page1()
        {
            return View();
        }
        public IActionResult Page2()
        {
            return View();
        }
    }
}