using System.Collections.Generic;

namespace ListingTodos.Models.Entities
{
    public class Assignee
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Todo> AssignedTodos { get; set; }
    }
}