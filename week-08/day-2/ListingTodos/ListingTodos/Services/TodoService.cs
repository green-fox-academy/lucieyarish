using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using ListingTodos.Models.Entities;
using ListingTodos.Persistence;

namespace ListingTodos.Services
{
    public class TodoService
    {
        private ApplicationDbContext DbContext { get; }

        public TodoService(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public List<Todo> FindAll()
        {
            return DbContext.Todos.ToList();
        }

        public List<Todo> FindActive()
        {
            var ActiveTodos = new List<Todo>();
            foreach (var todo in DbContext.Todos)
            {
                if (!todo.IsDone)
                {
                    ActiveTodos.Add(todo);
                }
            }

            return ActiveTodos;
        }

        public Todo CreateTodo(Todo todo)
        {
            var savedTodo = DbContext.Todos.Add(todo).Entity;
            DbContext.SaveChanges();
            return savedTodo;
        }
    }
}