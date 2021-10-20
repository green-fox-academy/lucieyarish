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
        
        [HttpGet("greeting")]
        public Greeting Greet([FromQuery] string name)
        {
            var greeting = new Greeting() {Id = 1, Content = $"Hello {name}"};
            return greeting;
        }
    }
}