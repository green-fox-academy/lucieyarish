using System;
using System.Collections.Generic;

namespace Blog
{
    public class Blog
    {
        private List<BlogPost> MyBlog;

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
            for (int j = 0; j < MyBlog.Count; j++)
            {
                MyBlog.RemoveAt(i);
            }
        }

        public void Update(int i, BlogPost post)
        {

        }
    }
}
