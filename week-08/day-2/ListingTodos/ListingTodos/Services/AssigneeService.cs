using System.Collections.Generic;
using System.Linq;
using ListingTodos.Models.Entities;
using ListingTodos.Persistence;

namespace ListingTodos.Services
{
    public class AssigneeService
    {
        private ApplicationDbContext DbContext { get; }

        public AssigneeService(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }
        
        public List<Assignee> FindAll()
        {
            return DbContext.Assignees.ToList();
        }
        
        public Assignee CreateAssignee(Assignee assignee)
        {
            var savedAssignee = DbContext.Assignees.Add(assignee).Entity;
            DbContext.SaveChanges();
            return savedAssignee;
        }
    }
}