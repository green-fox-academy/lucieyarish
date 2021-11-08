using Microsoft.EntityFrameworkCore;
using Reddit.Models.Entities;

namespace Reddit.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
    
    
}