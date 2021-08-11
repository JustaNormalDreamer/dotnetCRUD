using System;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace techlink.Posts
{
    [Route("posts")]
    public class BlogController : Controller
    {
        private IPostService _postService; 

        public BlogController(IPostService postService) {
            _postService = postService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            ViewData["Title"] = "Techlink Blog Page";
            ViewBag.Posts = await _postService.all();
            return View("Views/Blog/Index.cshtml");
        }

        
        [HttpGet("{id}")]
        public async Task<IActionResult> Show(string id)
        {
            ViewData["Title"] = "Techlink Post Show Page";
            ViewBag.Post = await _postService.show(id);
            return View("Views/Blog/Show.cshtml");
        }

        [HttpGet("create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Store(PostRequest postRequest)
        {
            string message = "";
            if(ModelState.IsValid) {
                Post post = new() {
                    Name = postRequest.name,
                    Description = postRequest.description,
                    Status = postRequest.status,
                };
                await _postService.store(post);

                message = "Post has been created successfully.";
            } else {
                return View("Views/Blog/Create.cshtml");
            }

            return Content(message);
        }

        [HttpGet("{id}/edit")]
        public async Task<IActionResult> Edit(string id)
        {
            ViewBag.Post = await _postService.show(id);
            return View();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(string id, PostRequest postRequest)
        {
            string message = "";
            if(ModelState.IsValid) {
                Post post = new() {
                    Name = postRequest.name,
                    Description = postRequest.description,
                    Status = postRequest.status,
                };
                await _postService.update(id, post);

                message = "Post has been updated successfully.";
            } else {
                return View("Views/Blog/Edit.cshtml");
            }

            return Content(message);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Destroy(string id)
        {
            await _postService.delete(id);
            return RedirectToRoute("posts");
        }
    }
}