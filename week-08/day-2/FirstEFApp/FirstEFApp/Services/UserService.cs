using System.Collections.Generic;
using System.Linq;
using FirstEFApp.Models.Entities;
using FirstEFApp.Persistence;

namespace FirstEFApp.Services
{
    public class UserService
    {
        private ApplicationDbContext DbContext { get; }

        public UserService(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public User FindById(int id)
        {
            return DbContext.Users.Find(id);
        }

        public User Add(User user)
        {
            var savedUser = DbContext.Users.Add(user).Entity;
            DbContext.SaveChanges();
            return savedUser;
        }

        public List<User> FindAll()
        {
            return DbContext.Users.ToList();
        }

        public List<User> FindByName(string username)
        {
            return DbContext.Users.Where(user => user.Name.Equals(username)).ToList();
        }
    }
}