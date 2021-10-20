using System;
using HelloWorldRESTApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorldRESTApp.Controllers
{
    [Route("web")]
    public class WebController : Controller
    {
        private static int count = 0;
        static string[] hellos = new string[]{"Mirëdita", "Ahalan", "Parev", "Zdravei", "Nei Ho", "Dobrý den", "Ahoj", "Goddag", "Goede dag, Hallo", "Hello", "Saluton", "Hei", "Bonjour",
            "Guten Tag", "Gia'sou", "Aloha", "Shalom", "Namaste", "Namaste", "Jó napot", "Halló", "Helló", "Góðan daginn", "Halo", "Aksunai", "Qanuipit", "Dia dhuit",
            "Salve", "Ciao", "Kon-nichiwa", "An-nyong Ha-se-yo", "Salvëte", "Ni hao", "Dzien' dobry", "Olá", "Bunã ziua", "Zdravstvuyte", "Hola", "Jambo", "Hujambo", "Hej",
            "Sa-wat-dee", "Merhaba", "Selam", "Vitayu", "Xin chào", "Hylo", "Sut Mae", "Sholem Aleychem", "Sawubona"};
        
        static int amount = hellos.Length;
        private static Random r = new();

        [HttpGet("greeting")]
        public IActionResult Greeting()
        {
            int rInt = r.Next(1, amount);
            int rFont = r.Next(1, 8);
            var greeting = new Greeting()
            {
                Id = count,
                Content = $"{hellos[rInt]}",
                FontSize = rFont,
            };
            count++;
            return View(greeting);
        }
        
        // public IActionResult Greeting([FromQuery] string name)
        // {
        //     var greeting = new Greeting()
        //     {
        //         Id = count++,
        //         Content = $"Hello, {name}! This site was loaded {count} times since last server start."
        //     };
        //
        //     return View(greeting);
        // }
    }
}