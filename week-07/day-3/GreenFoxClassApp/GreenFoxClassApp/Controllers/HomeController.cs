using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using GreenFoxClassApp.Models;
using GreenFoxClassApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace GreenFoxClassApp.Controllers
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
        public IActionResult StudentsView()
        {
            var result = new IndexViewModel(Service.FindAll());
            return View(result);
        }
        
        [HttpGet("gfa/add")]
        public IActionResult AddStudent()
        {
            return View("AddStudentView");
        }

        // [HttpGet("gfa/save")]
        // public IActionResult SaveStudent(string studentName)
        // {
        //     Service.Save(studentName);
        // }
    }
}