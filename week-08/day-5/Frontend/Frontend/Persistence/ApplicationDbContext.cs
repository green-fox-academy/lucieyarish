using Frontend.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Frontend.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Log> Logs { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
}