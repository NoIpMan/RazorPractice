using Microsoft.AspNetCore.Mvc;
using RazorPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPractice.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Product myProduct = new Product
            {
                ProductID = 1,
                Name = "Kayak",
                Category = "Water Sports",
                Description = "One man bolt",
                Price = 275M
            };
            Product[] array =
            {
                new Product { Name = "Kayak", Price = 275M },
                new Product { Name = "Life jacket", Price = 48.95M },
                new Product { Name = "Football", Price = 19.50M },
                new Product { Name = "Flag", Price = 34.95M}
            };
            return View(array);
        }
    }
}
