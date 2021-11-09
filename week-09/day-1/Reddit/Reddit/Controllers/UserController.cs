using Microsoft.AspNetCore.Mvc;
using Reddit.Services;

namespace Reddit.Controllers
{
    public class UserController : Controller
    {
        private UserService UserService { get; }

        public UserController(UserService userService)
        {
            UserService = userService;
        }
    }
}