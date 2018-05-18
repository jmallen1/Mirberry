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
    }
}