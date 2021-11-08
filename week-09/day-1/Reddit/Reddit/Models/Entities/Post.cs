namespace Reddit.Models.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public int NumberOfVotes { get; set; }
        public string PostTitle { get; set; }
        public string PostURL { get; set; }
    }
}