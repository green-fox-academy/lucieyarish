using System;
using HelloWorldRESTApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace HelloWorldRESTApp.Controllers
{
    [Route("api")]
    public class RestController : Controller
    {
        static int count = 1;
        
        [HttpGet("greeting")]
        public Greeting Greet([FromQuery] string name)
        {
            var greeting = new Greeting() {Id = count++, Content = $"Hello {name}"};
            return greeting;
        }
    }
}