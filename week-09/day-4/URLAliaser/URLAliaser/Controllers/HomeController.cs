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

            if (LinkService.CheckIfExists(link) == false)
            {
                var savedLink = LinkService.SaveLink(link);
                var result = new LinkViewModel()
                {
                    Link = savedLink
                };
                return View("YourLink", result);
            }
            return View("ErrorMessage");
        }
        
        [HttpGet("a/{alias}")]
        public IActionResult ViewLink([FromRoute] string alias)
        {
            if (LinkService.CheckIfAliasExists(alias) == false)
            {
                return NotFound(new {error = "Alias not found!"});
            }

            var linkToVisit = LinkService.FindByAlias(alias);

            return Redirect(linkToVisit);
        }

        [HttpGet("api/links")]
        public IActionResult ViewLink()
        {
            var allLinks = LinkService.DisplayLinks();
            return Ok(new
            {
                Links = allLinks
            });
        }

        [HttpDelete("api/links/{id}")]
        public IActionResult DeleteLink([FromRoute]int id)
        {
            Link toDelete = LinkService.FindById(id);
            if (toDelete is null)
            {
                return NotFound();
            }
            LinkService.Remove(toDelete);
            return NoContent();
        }
    }
}