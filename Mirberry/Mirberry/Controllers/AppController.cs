using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Mirberry.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {           
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Title = "About";

            return View();
        }
        public IActionResult Gym()
        {
            ViewBag.Title = "Gym";

            return View();
        }
        public IActionResult Food()
        {
            ViewBag.Title = "Food";

            return View();
        }
        public IActionResult Travel()
        {
            ViewBag.Title = "Travel";

            return View();
        }
    }
}