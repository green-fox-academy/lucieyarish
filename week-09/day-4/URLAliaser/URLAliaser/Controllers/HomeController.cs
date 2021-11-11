using System.Data.Common;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using URLAliaser.Models.Entities;
using URLAliaser.Services;
using URLAliaser.ViewModels;

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
        
        [HttpPost("save-link")]
        public IActionResult SaveLink(Link link)
        {
            var savedLink = LinkService.SaveLink(link);
            var result = new LinkViewModel()
            {
                Link = savedLink
            };
            return View("YourLink", result);
        }
        //
        // [HttpGet("your-link")]
        // public IActionResult YourLink()
        // {
        //     return View();
        // }
        
    }
}