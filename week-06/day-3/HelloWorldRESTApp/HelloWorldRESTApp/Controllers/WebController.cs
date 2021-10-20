using HelloWorldRESTApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorldRESTApp.Controllers
{
    [Route("web")]
    public class WebController : Controller
    {
        [HttpGet("greeting")]
        public IActionResult Greeting()
        {
            var greeting = new Greeting()
            {
                Id = 1,
                Content = "from the model"
            };

            return View(greeting);
        }
    }
}