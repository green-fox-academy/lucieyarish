using System.Data.Common;
using Microsoft.EntityFrameworkCore;
using URLAliaser.Models.Entities;

namespace URLAliaser.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Link> Links { get; set; } 
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
}