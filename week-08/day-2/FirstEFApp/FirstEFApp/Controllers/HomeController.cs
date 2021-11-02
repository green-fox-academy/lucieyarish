using FirstEFApp.Models;
using FirstEFApp.Models.Entities;
using FirstEFApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace FirstEFApp.Controllers
{
    [Route("home")]
    public class HomeController : Controller
    {
        private UserService UserService { get; }
        public HomeController(UserService service)
        {
            UserService = service;
        }

        [HttpGet("users/{id:int?}")]
        public IActionResult Index([FromRoute] int id)
        {
            User user = UserService.FindById(id);

            var viewModel = new IndexViewModel() { User = user, AllUsers = UserService.FindAll() };
            return View(viewModel);
        }

        [HttpPost("users")]
        public IActionResult AddUser([FromForm] User user)
        {
            var savedUser = UserService.Add(user);
            return LocalRedirect($"~/users/{savedUser.Id}");
        }
    }
}