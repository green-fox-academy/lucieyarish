using Microsoft.AspNetCore.Mvc;

namespace FirstWebApp.Controllers
{
    //controller maps what method will be launched and when
    //if path contains the word "home", launch the method inside the controller
    [Route("home")]
    public class HomeController : Controller
    {
        // GET
        //if path contains the word "home", launch this controller
        [HttpGet("pepa")]
        public string Index()
        {
            //no need to specify path to the file because the name of the method automatically looks for file named "index"
            //if different path is needed, can specify path: return View("path.cshtml");
            return "Hello from the Controller!";
        }
    }
}