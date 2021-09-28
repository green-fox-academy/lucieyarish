using System;
using System.Collections.Generic;

namespace Blog
{
    public class BlogPost
    {
        private string AuthorName { get; set; }
        private string Title { get; set; }
        private string Text { get; set; }
        private string PublicationDate { get; set; }

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
