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

        [HttpGet("all")]
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
        
        [HttpGet("{id:long}/delete")]
        public IActionResult DeleteAssignee([FromRoute] long id)
        {
            AssigneeService.RemoveAssignee(id);
            return LocalRedirect($"~/assignee/all");
        }
        
        [HttpGet("{id:long}/edit")]
        public IActionResult EditAssignee([FromRoute] long id)
        {
            var foundAssignee = AssigneeService.FindById(id);
            var assignee = new AssigneeViewModel()
            {
                Assignee = foundAssignee
            };
            return View("EditAssignee", assignee);
        }
        
        [HttpPost("{id:long}/edit")]
        public IActionResult EditAssignee([FromRoute]long id, Assignee assignee)
        {
            AssigneeService.EditAssignee(id, assignee);
            return LocalRedirect($"~/assignee/all"); 
        }
    }
}