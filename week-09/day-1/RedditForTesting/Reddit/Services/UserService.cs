using Microsoft.EntityFrameworkCore.Query;
using Reddit.Models.Entities;
using Reddit.Persistence;

namespace Reddit.Services
{
    public class UserService
    {
        private ApplicationDbContext DbContext { get; }

        public UserService(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public User CreateUser(User user)
        {
            var savedUser = DbContext.Users.Add(user).Entity;
            DbContext.SaveChanges();
            return savedUser;
        }
    }
}