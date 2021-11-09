using Microsoft.AspNetCore.Mvc;
using Reddit.Models.Entities;
using Reddit.Services;
using Reddit.ViewModels;

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
        
        public IActionResult ListAll()
        {
            var posts = new PostViewModel()
            {
                Posts = PostService.FindAll()
            };
            return View("Index", posts);
        }

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
        
        []
    }
}