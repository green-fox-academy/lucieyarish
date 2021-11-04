using System.Collections.Generic;
using System.Linq;
using ListingTodos.Models.Entities;
using ListingTodos.Persistence;
using Microsoft.EntityFrameworkCore;

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
            // return DbContext.Assignees.ToList();
            return DbContext.Assignees.Include(a => a.AssignedTodos).ToList();
        }
        
        public Assignee CreateAssignee(Assignee assignee)
        {
            var savedAssignee = DbContext.Assignees.Add(assignee).Entity;
            DbContext.SaveChanges();
            return savedAssignee;
        }
        
        public Assignee FindById(long id)
        {
            var foundPerson = FindAll().Where(a => a.Id == id).ToList().First();
            return foundPerson;
        }
        
        public void RemoveAssignee(long id)
        {
            DbContext.Assignees.Remove(FindById(id));
            DbContext.SaveChanges();
        }
        public List<Assignee> SearchAssignee(string assignee)
        {
            var allAssignees = DbContext.Assignees;
            var foundassignee = allAssignees
                .Where(t => (t.Name.Contains(assignee)) || (t.Email.Contains(assignee)))
                .ToList();
            return foundassignee;
        }

        public void EditAssignee(long id, Assignee newAssignee)
        {
            var foundAssignee = FindById(id);
            foundAssignee.Name = newAssignee.Name;
            foundAssignee.Email = newAssignee.Email;
            DbContext.SaveChanges();

        }
        
        

        public void GetDetails(long id, Assignee newAssignee)
        {
            var foundAssignee = FindById(id);
            foundAssignee.AssignedTodos = newAssignee.AssignedTodos;
        }
    }
}