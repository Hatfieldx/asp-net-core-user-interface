using Microsoft.AspNetCore.Mvc;

namespace lesson1.Controllers
{
    [Route("Calc/{action}/{x:int}/{y:int}")]
    public class CalcController : Controller
    {
        public IActionResult Add(int x, int y)
        {
            return Content(string.Format($"summ {x + y}"));
        }
        public IActionResult Mul(int x, int y)
        {
            return Content(string.Format($"mul {x * y}"));
        }
        public IActionResult Div(int x, int y)
        {
            return Content(string.Format($"div {x / y}"));
        }
        public IActionResult Sub(int x, int y)
        {
            return Content(string.Format($"sub {x - y}"));
        }
    }
}