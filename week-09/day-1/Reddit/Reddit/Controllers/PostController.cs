using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using Reddit.Models.Entities;
using Reddit.Services;
using Reddit.ViewModels;
using cloudscribe.Pagination.Models;
using Microsoft.EntityFrameworkCore;

namespace Reddit.Controllers
{
    [Route("")]
    public class PostController : Controller
    {
        private PostService PostService { get; }

        public PostController(PostService postService)
        {
            PostService = postService;
        }
        
        public IActionResult ListAll([FromQuery]int pageNumber = 1, int pageSize = 10)
        {
            // var posts = new PostViewModel()
            // {
            //     Posts = PostService.ListTopTen(pageNumber, pageSize)
            // };
            var result = new PagedResult<Post>()
            {
                Data = PostService.ListTopTen(pageNumber, pageSize),
                TotalItems = PostService.FindAll().Count,
                PageNumber = pageNumber,
                PageSize = pageSize
            };
            return View("Index", result);
            return View("Index", result);
        }
        
        // public IActionResult ListAll2()
        // {
        //     var posts = new PostViewModel()
        //     {
        //         Posts = PostService.ListTopTen()
        //     };
        //     return View("Index", posts);
        // }

        [HttpGet("add")]
        public IActionResult Add()
        {
            return View("AddPost");
        }

        [HttpPost("add")]
        public IActionResult Add(Post post)
        {
            PostService.CreatePost(post);
            return RedirectToAction("ListAll");
        }

        [HttpGet("{id:long}/voteup")]
        public IActionResult VoteUp([FromRoute] long id)
        {
            PostService.EditVoteUp(id);
            return RedirectToAction("ListAll");
        }
        
        [HttpGet("{id:long}/votedown")]
        public IActionResult VoteDown([FromRoute] long id)
        {
            PostService.EditVoteDown(id);
            return RedirectToAction("ListAll");
        }

        [HttpGet("search")]
        public IActionResult SearchPost([FromQuery] string post)
        {
            // var foundPosts = PostService.SearchPost(post);
            // var posts = new PostViewModel()
            // {
            //     Posts = foundPosts
            // };
            var result = new PagedResult<Post>()
            {
                Data = PostService.SearchPost(post),
            };
            return View("Index", result);
        }
    }
}