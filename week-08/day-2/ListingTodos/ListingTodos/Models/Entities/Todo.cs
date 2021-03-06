namespace ListingTodos.Models.Entities
{
    public class Todo
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsUrgent { get; set; }
        public bool IsDone { get; set; }
        public Assignee Assignee { get; set; }
        public long? AssigneeID { get; set; }
        
        public string CreateDate { get; set; }
        
        public string DueDate { get; set; }
    }
}