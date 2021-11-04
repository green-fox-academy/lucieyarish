using System.Collections.Generic;
using ListingTodos.Models.Entities;

namespace ListingTodos.Models
{
    public class TodoViewModel
    {
        public Todo Todo { get; set; }
        
        public List<Todo> AllTodos { get; set; }
        public Assignee Assignee { get; set; }
        public List<Assignee> AllAssignees { get; set; }
    }
}