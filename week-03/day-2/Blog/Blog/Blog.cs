using System;
using System.Collections.Generic;
using Microsoft.VisualBasic.CompilerServices;

namespace Blog
{
    public class Blog
    {
        public List<BlogPost> MyBlog { get; set; }

        public Blog()
        {
            MyBlog = new List<BlogPost>();
        }

        public void Add(BlogPost post)
        {
            MyBlog.Add(post);
        }

        public void Delete(int i)
        {
            MyBlog.RemoveAt(i);
        }

        public void Update(int i, BlogPost post)
        {
            MyBlog[i] = post;
        }

        public void PrintAll()
        {
            foreach (BlogPost item in MyBlog)
            {
                Console.WriteLine(item);
            }
        }
    }
}
