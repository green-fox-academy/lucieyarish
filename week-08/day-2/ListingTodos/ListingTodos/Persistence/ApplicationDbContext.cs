using ListingTodos.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace ListingTodos.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        
    }
}