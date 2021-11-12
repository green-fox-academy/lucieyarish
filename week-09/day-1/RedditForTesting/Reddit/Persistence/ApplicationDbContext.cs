using Microsoft.EntityFrameworkCore;
using Reddit.Models.Entities;

namespace Reddit.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>()
                .HasOne<User>(p => p.User)
                .WithMany(x => x.UsersPosts)
                .HasForeignKey(t => t.UserId)
                .IsRequired(false);
        }
    }
    
    
}