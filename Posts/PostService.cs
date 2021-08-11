using System.Collections.Generic;
using System.Threading.Tasks;

namespace techlink.Posts
{
    public class PostService : IPostService
    {
        private readonly IPostRepository _postRepository;

        public PostService(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public async Task<IEnumerable<PostResource>> all()
        {
            List<PostResource> posts = new List<PostResource>();

            foreach(Post post in await _postRepository.all()) 
            {
                posts.Add(new PostResource(post.Id, post.Name, post.Description, post.Status, post.CreatedAt, post.UpdatedAt));
            }

            return posts;
        }

        public async Task<PostResource> show(string id)
        {
            Post post = await _postRepository.show(id);
            PostResource postResource = new PostResource(post.Id, post.Name, post.Description, post.Status, post.CreatedAt, post.UpdatedAt);
            return postResource;
        }

        public async Task store(Post post)
        {
            await _postRepository.store(post);
        }

        public async Task update(string id, Post post) 
        {
            await _postRepository.update(id, post);
        }

        public async Task delete(string id) 
        {
            await _postRepository.delete(id);
        }
    }
}