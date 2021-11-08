using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Reddit.Models.Entities;
using Reddit.Persistence;
using Reddit.ViewModels;

namespace Reddit.Services
{
    public class PostService
    {
        private ApplicationDbContext DbContext { get; }
        public PostService(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public List<Post> FindAll()
        {
            return DbContext.Posts.ToList();
        }

        public Post CreatePost(Post post)
        {
            var savedPost = DbContext.Posts.Add(post).Entity;
            DbContext.SaveChanges();
            return savedPost;
        }

        public Post FindById(long id)
        {
            var foundPost = FindAll().Where(a => a.Id == id).ToList().First();
            return foundPost;
        }

        public void EditVoteUp(long id, Post post)
        {
            var foundPost = FindById(id);
            foundPost.NumberOfVotes += 1;
            foundPost.PostTitle = post.PostTitle;
            foundPost.PostURL = post.PostURL;
            DbContext.SaveChanges();
        }
        
    }
}