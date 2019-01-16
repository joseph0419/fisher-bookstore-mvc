using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class HomeController : Controllers
    {
        public IActionResult Index()
        {
            return Content("Hello World");
        }
    }
}