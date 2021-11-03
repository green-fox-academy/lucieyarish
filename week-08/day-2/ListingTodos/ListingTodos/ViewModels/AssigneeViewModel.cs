using System.Collections.Generic;
using ListingTodos.Models.Entities;

namespace ListingTodos.Models
{
    public class AssigneeViewModel
    {
        public Assignee Assignee { get; set; }
        
        public List<Assignee> Assignees { get; set; }
    }
}