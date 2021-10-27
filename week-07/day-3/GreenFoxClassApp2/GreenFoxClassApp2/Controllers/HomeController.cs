using GreenFoxClassApp2.Services;
using Microsoft.AspNetCore.Mvc;

namespace GreenFoxClassApp2.Controllers
{
    public class HomeController : Controller
    {
        private StudentService Service { get; }
        
        public HomeController(StudentService studentService)
        {
            Service = studentService;
        }
        
        [HttpGet("gfa")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("gfa/list")]
        public IActionResult ViewStudents()
        {
            return View("ViewStudents", Service);
        }

        [HttpGet("gfa/add")]
        public IActionResult AddStudent()
        {
            return View("AddStudent");
        }

        [HttpGet("gfa/save")]
        public IActionResult SaveStudent(string student)
        {
            Service.Save(student);
            return View("ViewStudents", Service);
        }
    }
}