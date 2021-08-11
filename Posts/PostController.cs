using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

using techlink.Posts;

namespace techlink.Controllers
{
    [ApiController]
    [Route("posts")]
    public class PostController : Controller
    {
        private IPostService _postService; 

        public PostController(IPostService postService) {
            _postService = postService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PostResource>>> Get() 
        {
            var result = await _postService.all();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PostResource>> Show(string id) {            
            return await _postService.show(id);
        }

        [HttpPost]       
        public async Task<ActionResult> Store(PostRequest postDto) {
            Post post = new() {
                Name = postDto.name,
                Description = postDto.description,
                Status = postDto.status
            };

            await _postService.store(post);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> update(string id, PostRequest postDto)
        {
            Post post = new() {
                Name = postDto.name,
                Description = postDto.description,
                Status = postDto.status
            };

            await _postService.update(id, post);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> destroy(string id)
        {
            await _postService.delete(id);
            return Ok();
        }
    }
}