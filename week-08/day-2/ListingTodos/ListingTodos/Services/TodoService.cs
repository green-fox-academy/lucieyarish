using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using ListingTodos.Models.Entities;
using ListingTodos.Persistence;
using Microsoft.EntityFrameworkCore;

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
            savedTodo.CreateDate = DateTime.Now.ToString();
            DbContext.SaveChanges();
            return savedTodo;
        }
        
        public Todo FindById(long id)
        {
            var foundTodo = DbContext.Todos.Where(t => t.Id == id).ToList().First();
            return foundTodo;
        }
        
        public void RemoveTodo(long id)
        {
            DbContext.Todos.Remove(FindById(id));
            DbContext.SaveChanges();
        }

        public List<Todo> SearchTodo(string todo)
        {
            var allTodos = DbContext.Todos;
            var foundTodos = allTodos
                .Where(t => (t.Title.Contains(todo)) || (t.Description.Contains(todo)))
                .ToList();
            return foundTodos;
        }

        public void EditTodo(long id, Todo newTodo, long assigneeId, string dueDate)
        {
            var foundTodo = FindById(id);
            foundTodo.Title = newTodo.Title;
            foundTodo.Description = newTodo.Description;
            foundTodo.IsUrgent = newTodo.IsUrgent;
            foundTodo.IsDone = newTodo.IsDone;
            foundTodo.AssigneeID = assigneeId;
            foundTodo.DueDate = dueDate;
            DbContext.SaveChanges();

        }
    }
}