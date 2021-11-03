using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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

        // [Route("")]
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
        
        // [HttpGet("list")]
        public IActionResult ListALl() {
            // Create a SQL query in the background
            var todos = new TodoViewModel()
            {
                AllTodos = TodoService.FindAll()
            };

            return View("List", todos);
        }

        [HttpGet("active")]
        public IActionResult ListActive()
        {
            var activeTodos = new TodoViewModel()
            {
                AllTodos = TodoService.FindActive()
            };

            return View("Active", activeTodos);
        }

        [HttpGet("add")]
        public IActionResult AddTodo()
        {
            return View("Add");
        }

        [HttpPost("add")]
        public IActionResult SubmitTodo(Todo todo)
        {
            TodoService.CreateTodo(todo);
            return RedirectToAction("ListAll");
        }

        [HttpGet("{id:long}/delete")]
        public IActionResult DeleteTodo([FromRoute] long id)
        {
            TodoService.RemoveTodo(id);
            return LocalRedirect($"~/todo/list");
        }

        [HttpGet("search")]
        public IActionResult Search([FromQuery]string todo)
        {
            var foundTodos = TodoService.SearchTodo(todo);
            var todos = new TodoViewModel()
            {
                AllTodos = foundTodos
            };
            return View("List", todos);
        }
        
        [HttpGet("{id:long}/edit")]
        public IActionResult EditTodo([FromRoute] long id)
        {
            var foundTodo = TodoService.FindById(id);
            var todo = new TodoViewModel()
            {
                Todo = foundTodo
            };
            return View("Edit", todo);
        }
        
        [HttpPost("{id:long}/edit")]
        public IActionResult EditTodo([FromRoute]long id, Todo todo)
        {
            TodoService.EditTodo(id, todo);
            return LocalRedirect($"~/todo/list"); 
        }
    }
}