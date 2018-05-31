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

        [HttpGet]
        public IActionResult About()
        {
              return View();
        }

        [HttpPost]
        public IActionResult About(ViewModels.AboutViewModel model)
        {
            if (ModelState.IsValid)
            {
                // do thing
                //TestConsoleWriter.Write("");
            }

            return View();
        }

        [HttpGet]
        public IActionResult Gym()
        {
           return View();
        }

        [HttpPost]
        public IActionResult About(ViewModels.GymViewModel model)
        {
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