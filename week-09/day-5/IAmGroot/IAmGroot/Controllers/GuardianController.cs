using IAmGroot.Models;
using Microsoft.AspNetCore.Mvc;

namespace IAmGroot.Controllers
{
    public class GuardianController : Controller
    {
        [HttpGet("groot")]
        public IActionResult GetGroot([FromQuery] string message)
        {
            string translatedText = "I am groot!";
            if (message is null)
            {
                return NotFound(new {error = "I am groot!"});
            }
            return Ok( new { received = message, translated = translatedText});
        }
    }
}