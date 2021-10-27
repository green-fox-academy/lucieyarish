using Microsoft.AspNetCore.Mvc;

namespace GreenFoxClassApp.Controllers
{
    public class HomeController
    {
        private StudentService StudentService { get; }

        public HomeController(StudentService studentService)
        {
            StudentService = studentService;
        }
        
        [HttpGet("/gfa")]
        
    }
}