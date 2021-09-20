using System;
namespace BlogPost
{
    public class BlogPost
    {
        private string AuthorName;
        private string Title;
        private string Text;
        private string PublicationDate;

        public BlogPost(string authorname, string title, string text, string publicationdate)
        {
            AuthorName = authorname;
            Title = title;
            Text = text;
            PublicationDate = publicationdate;
        }

        public void CreateBlogPost()
        {
            Console.WriteLine($"'{Title}' written by {AuthorName} published on {PublicationDate}. {Text}");
        }
    }
}
