using System;
using System.Collections.Generic;
using FoxClub.Services;
using Microsoft.AspNetCore.Mvc;

namespace FoxClub.Controllers
{
    
    [Route("/")]
    public class HomeController : Controller
    {
        public FoxService Service { get; set; }

        public HomeController(FoxService service)
        {
            Service = service;
        }
        public IActionResult Index()
        {
            // if (string.IsNullOrEmpty(name))
            // {
            //     return View("Login");
            // }
            // var fox = Service.GetFox(name);
            // if (fox == null)
            // {
            //     return View("Login");
            // }
            return View(Service);
        }

        [HttpGet("login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("login")]
        public IActionResult Login(string name)
        {
            Service.AddFox(name);
            return RedirectToAction("Index");
            // return RedirectToAction("Index",
            // new { name = name
            // });
        }

        [HttpGet("store")]
        public IActionResult Store()
        {
            return View();
        }

        [HttpPost("choose")]
        public IActionResult Choose(string food, string drink)
        {
            Service.LoggedFox.Food = food;
            Service.LoggedFox.Drink = drink;
            return RedirectToAction("Index");
        }

        [HttpGet("trick")]
        public IActionResult Trick()
        {
            return View();
        }
        
        [HttpPost("learn")]
        public IActionResult Learn(string trick)
        {
            Service.AddTrick(trick);
            Service.LoggedFox.Tricks = new List<string>();
            return RedirectToAction("Index");
        }
    }
}