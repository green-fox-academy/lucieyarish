using GreenFoxClassApp2.Services;
using Microsoft.AspNetCore.Mvc;

namespace GreenFoxClassApp2.Controllers
{
    [Route("gfa")]
    public class HomeController : Controller
    {
        private StudentService Service { get; }
        
        public HomeController(StudentService studentService)
        {
            Service = studentService;
        }
        
        public IActionResult Index()
        {
            return View(Service);
        }

        [HttpGet("list")]
        public IActionResult ViewStudents()
        {
            return View("ViewStudents", Service);
        }

        [HttpGet("add")]
        public IActionResult AddStudent()
        {
            return View(Service);
        }

        [HttpGet("save")]
        public IActionResult SaveStudent(string student)
        {
            Service.Save(student);
            return View("ViewStudents", Service);
        }

        [HttpGet("check")]
        public IActionResult Check()
        {
            return View(Service);
        }
        
        [HttpPost("checkexists")]
        public IActionResult CheckExists(string student)
        {
            Service.Check(student);
            return RedirectToAction("Check", Service);
        }
    }
}