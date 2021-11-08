using System.Collections.Generic;
using Reddit.Models.Entities;

namespace Reddit.ViewModels
{
    public class PostViewModel
    {
        public Post Post { get; set; }
        public List<Post> Posts { get; set; }
    }
}