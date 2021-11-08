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
        
    }
}