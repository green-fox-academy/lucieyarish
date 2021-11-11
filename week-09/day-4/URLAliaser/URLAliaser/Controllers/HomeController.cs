using Microsoft.AspNetCore.Mvc;
using URLAliaser.Services;

namespace URLAliaser.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private LinkService LinkService { get; }

        public HomeController(LinkService service)
        {
            LinkService = service;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
        
    }
}