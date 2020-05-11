using lesson6.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lesson6.Components
{
    public class ProductsTable : ViewComponent
    {
        public IViewComponentResult Invoke(IEnumerable<Product> products)
        {
            return View("ProductsTable", products);
        }
    }
}
