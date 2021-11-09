using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
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

        public List<Post> ListTopTen(int pageNumber, int pageSize)
        {
            int ExcludedRecords = (pageSize * pageNumber) - pageSize;
            var topTenPosts = DbContext.Posts
                .Skip(ExcludedRecords)
                .OrderByDescending(p => p.NumberOfVotes)
                .Take(10)
                .ToList();
            return topTenPosts;
        }

        public Post CreatePost(Post post)
        {
            var savedPost = DbContext.Posts.Add(post).Entity;
            savedPost.CreatedAt = DateTime.Now;
            DbContext.SaveChanges();
            return savedPost;
        }

        public Post FindById(long id)
        {
            var foundPost = FindAll().Where(a => a.Id == id).ToList().First();
            return foundPost;
        }

        public void EditVoteUp(long id)
        {
            var foundPost = FindById(id);
            foundPost.NumberOfVotes += 1;
            // foundPost.PostTitle = post.PostTitle;
            // foundPost.PostURL = post.PostURL;
            DbContext.SaveChanges();
        }
        
        public void EditVoteDown(long id)
        {
            var foundPost = FindById(id);
            if (foundPost.NumberOfVotes > 0)
            {
                foundPost.NumberOfVotes -= 1;
            }
            // foundPost.PostTitle = post.PostTitle;
            // foundPost.PostURL = post.PostURL;
            DbContext.SaveChanges();
        }

        public List<Post> SearchPost(string post)
        {
            var allPosts = DbContext.Posts;
            var foundPosts = allPosts
                .Where(p => p.PostTitle.Contains(post))
                .ToList();
            return foundPosts;
        }
    }
}