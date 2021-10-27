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
            return View("ValidateEmail", UtilityService.ValidateEmail(email));
        }

        [HttpGet("encoding")]
        public IActionResult EncodeText([FromQuery] string text, int shift)
        {
            return View("EncodedText", UtilityService.Caesar(text, shift));
        }
        
        [HttpGet("decoding")]
        public IActionResult DecodeText([FromQuery] string text, int shift)
        {
            return View("DecodedText", UtilityService.Caesar(text, -shift));
        }
    }
    
}