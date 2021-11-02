using System.Collections.Generic;
using FirstEFApp.Models.Entities;

namespace FirstEFApp.Models
{
    public class IndexViewModel
    {
        public User User { get; set; }
        
        public List<User> AllUsers { get; set; }
    }
}