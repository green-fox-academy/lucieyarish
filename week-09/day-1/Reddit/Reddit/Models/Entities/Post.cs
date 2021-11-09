using System;

namespace Reddit.Models.Entities
{
    public class Post
    {
        public long Id { get; set; }
        public int NumberOfVotes { get; set; }
        public string PostTitle { get; set; }
        public string PostURL { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}