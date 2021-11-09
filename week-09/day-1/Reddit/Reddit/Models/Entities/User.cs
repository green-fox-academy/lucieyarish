using System.Collections.Generic;

namespace Reddit.Models.Entities
{
    public class User
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public List<Post> UsersPosts { get; set; }
    }
}