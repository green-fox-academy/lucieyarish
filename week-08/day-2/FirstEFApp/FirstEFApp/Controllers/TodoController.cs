using Microsoft.AspNetCore.Mvc;

namespace FirstEFApp.Controllers
{
    [Route("todo")]
    public class TodoController : Controller
    {
        [Route("")]
        [Route("list")]
        [HttpGet]
        public string List()
        {
            return "This is my first todo";
        }
    }
}