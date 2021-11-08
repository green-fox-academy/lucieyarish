using Microsoft.AspNetCore.Mvc;
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
        
    }
}