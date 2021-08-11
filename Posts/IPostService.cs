
using System.Collections.Generic;
using System.Threading.Tasks;

namespace techlink.Posts
{
    public interface IPostService
    {
        public Task<IEnumerable<PostResource>> all();

        public Task<PostResource> show(string id);

        public Task store(Post post);

        public Task update(string id, Post post);

        public Task delete(string id);
    }
}