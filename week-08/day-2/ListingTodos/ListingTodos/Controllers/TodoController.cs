using System.Collections.Generic;
using System.Linq;
using ListingTodos.Models;
using ListingTodos.Models.Entities;
using ListingTodos.Persistence;
using ListingTodos.Services;
using Microsoft.AspNetCore.Mvc;

namespace ListingTodos.Controllers
{
    [Route("todo")]
    public class TodoController : Controller
    {
        // private static List<string> todos;
        private TodoService TodoService { get; }

        // static TodoController()
        // {
        //     todos = new List<string>();
        // }
        
        public TodoController(TodoService service)
        {
            TodoService = service;
        }

        [Route("")]
        [Route("list")]
        // [HttpGet]
        // public IActionResult List()
        // {
        //     todos.Add("Create a CRUD project");
        //     todos.Add("Learn DB");
        //     todos.Add("Relax");
        //     todos.Add("Sleep");
        //     return View("List", todos);
        // }
        
        [HttpGet]
        public IActionResult ListALl() {
            // Create a SQL query in the background
            var todos = new TodoViewModel()
            {
                AllTodos = TodoService.FindAll()
            };

            return View("List", todos);
        }
    }
}