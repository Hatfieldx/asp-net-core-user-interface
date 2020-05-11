using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace lesson5.Controllers
{
    public class SubMenuController : Controller
    {
        public IActionResult Menu1()
        {
            return View();
        }
        public IActionResult Menu2()
        {
            return View();
        }
        public IActionResult Menu3()
        {
            return View();
        }
    }
}