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
        public ViewResult Index()
        {
            Product myProduct = new Product
            {
                ProductID = 1,
                Name = "Kayak",
                Category = "Water Sports",
                Description = "One man bolt",
                Price = 275M
            };
            return View(myProduct);
        }
    }
}
