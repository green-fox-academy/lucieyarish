using System;
using System.Collections.Generic;

namespace Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            Blog blog = new Blog();
            
            BlogPost post1 = new BlogPost("John Doe", "Lorem Ipsum", "Lorem ipsum dolor sit amet.", "2000.05.04");
            BlogPost post2 = new BlogPost("Tim Urban", "Wait but why", "A popular long-form, stick-figure-illustrated blog about almost everything.", "2010.10.10"); 
            BlogPost post3 = new BlogPost("William Turton", "One Engineer Is Trying to Get IBM to Reckon With Trump", "Daniel Hanley, a cybersecurity engineer at IBM, doesn’t want to be the center of attention. When I asked to take his picture outside one of IBM’s New York City offices, he told me that he wasn’t really into the whole organizer profile thing.", "2017.03.28");
            
            blog.MyBlog.Add(post1);
            blog.MyBlog.Add(post2);
            blog.MyBlog.Add(post3);

            BlogPost updatePost = new BlogPost("Tim Urban", "Wait but why",
                "A popular long-form, stick-figure-illustrated blog about almost everything. Bla bla.", "2010.10.10");
            blog.Update(1, updatePost);
            blog.PrintAll();
            // Console.WriteLine(blog.MyBlog[1].ToString());
        }
    }
}
