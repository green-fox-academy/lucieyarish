using System.Collections.Generic;
using Reddit.Models.Entities;

namespace Reddit.ViewModels
{
    public class UserViewModel
    {
        public User User { get; set; }

        public List<User> Users { get; set; }
    }
}