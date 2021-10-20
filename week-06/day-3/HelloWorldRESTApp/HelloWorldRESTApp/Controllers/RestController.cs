using HelloWorldRESTApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorldRESTApp.Controllers
{
    [Route("api")]
    public class RestController : Controller
    {
        // public IActionResult Index()
        // {
        //     return View("Index");
        // }
        static int count = 1;
        
        [HttpGet("greeting")]
        public Greeting Greet([FromQuery] string name)
        {
            var greeting = new Greeting() {Id = count++, Content = $"Hello {name}"};
            return greeting;
        }
    }
}