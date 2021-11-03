using ListingTodos.Models;
using ListingTodos.Models.Entities;
using ListingTodos.Services;
using Microsoft.AspNetCore.Mvc;

namespace ListingTodos.Controllers
{
    [Route("assignee")]
    public class AssigneeController : Controller
    {
        private AssigneeService AssigneeService { get; }

        public AssigneeController(AssigneeService service)
        {
            AssigneeService = service;
        }

        [HttpGet("assignees")]
        public IActionResult ListAll()
        {
            var assignees = new AssigneeViewModel()
            {
                Assignees = AssigneeService.FindAll()
            };

            return View("Assignees", assignees);
        }
        
        [HttpGet("add")]
        public IActionResult AddAssignee()
        {
            return View("AddAssignee");
        }
        
        [HttpPost("add")]
        public IActionResult SubmitAssignee(Assignee assignee)
        {
            AssigneeService.CreateAssignee(assignee);
            return RedirectToAction("ListAll");
        }
    }
}