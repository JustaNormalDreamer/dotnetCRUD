using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using techlink.Db;

namespace techlink.Posts
{
    public class PostRepository : IPostRepository
    {
        private readonly IDataContext _context;

        public PostRepository(IDataContext dataContext) {
            _context = dataContext;
        }

        public async Task<IEnumerable<Post>> all()
        {
            return await _context.Posts.ToListAsync();
        }

        public async Task<Post> show(string id)
        {
            return await this.findPostById(id);
        }

        public async Task store(Post post)
        {
            _context.Posts.Add(post);   
            await _context.SaveChangesAsync();
        }

        public async Task update(string id, Post post)
        {
            Post oldPost = await this.findPostById(id);
            oldPost.Name = post.Name;
            oldPost.Description = post.Description;
            oldPost.Status = post.Status;
            await _context.SaveChangesAsync();
        }

        public async Task delete(string id) 
        {
            Post post = await this.findPostById(id);
            _context.Posts.Remove(post);
            await _context.SaveChangesAsync();
        }

        private async Task<Post> findPostById(string id)
        {
            Post post = await _context.Posts.FindAsync(id);
            if(post == null)
            {
                throw new NullReferenceException();
            }

            return post;
        }
    }
}