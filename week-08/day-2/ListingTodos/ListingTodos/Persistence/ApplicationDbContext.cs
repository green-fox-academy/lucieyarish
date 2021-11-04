using ListingTodos.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace ListingTodos.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }
        public DbSet<Assignee> Assignees { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Todo>()
                .HasOne<Assignee>(t => t.Assignee)
                .WithMany(x => x.AssignedTodos)
                .HasForeignKey(t => t.AssigneeID)
                .IsRequired(false);
        }
        
    }
}