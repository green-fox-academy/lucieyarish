using Microsoft.AspNetCore.Mvc;
using UsefulUtilitiesDependencyInjection.Models;
using UsefulUtilitiesDependencyInjection.ViewModel;

namespace UsefulUtilitiesDependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        private UtilityService UtilityService { get; }

        public HomeController(UtilityService utilityService)
        {
            UtilityService = utilityService;
        }

        [HttpGet("useful")]
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpGet("/useful/colored")]
        public IActionResult ColoredPage()
        {
            var viewModel = new IndexViewModel(UtilityService.RandomColor());
            return View("Index", viewModel);
        }

        [HttpGet("/useful/email")]
        public IActionResult EmailValidation([FromQuery]string email)
        {
            return View("ValidateEmail");
        }
    }
    
}