using Microsoft.AspNetCore.Mvc;
using Reddit.Models.Entities;
using Reddit.Services;
using Reddit.ViewModels;

namespace Reddit.Controllers
{
    public class UserController : Controller
    {
        private UserService UserService { get; }

        public UserController(UserService userService)
        {
            UserService = userService;
        }

        [HttpGet("login")]
        public IActionResult UserLogin()
        {
            var user = new UserViewModel()
            {
               
            };
            return View("Login", user);
        }

        [HttpPost("login")]
        public IActionResult UserLogin([FromQuery] long userID)
        {
            return RedirectToAction("ListAll", "Post");
        }
        
        [HttpPost("signup")]
        public IActionResult CreateUser(User user)
        {
            UserService.CreateUser(user);
            return RedirectToAction("ListAll", "Post");
        }
    }
}