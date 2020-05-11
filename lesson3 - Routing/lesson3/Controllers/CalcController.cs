using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lesson3.Models;
using Microsoft.AspNetCore.Mvc;

namespace lesson3.Controllers
{
    public enum Operations
    {
        Sum = 0,
        Sub,
        Mult,
        Div
    }
    
    public class CalcController : Controller
    {
        public IActionResult Index(Operations? operation, int? numx, int? numy)
        {
            string result = "";

            if (operation.HasValue)
            {
                result = Solve(operation, numx, numy);
            }
            ViewData["userAgent"] = Request.Headers["user-agent"];

            return View("Index", new SolversView{X = numx ?? 0, Y = numy ?? 0, Result = result });
        }

        private string Solve(Operations? operation, int? x, int? y) => operation switch
        {
            Operations.Sum  => (x + y).ToString(),
            Operations.Sub  => (x - y).ToString(),
            Operations.Mult => (x * y).ToString(),
            Operations.Div  => ((double)x / y).ToString(),
            _=>"error"
        };
       
    }
}