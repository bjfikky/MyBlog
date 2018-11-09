using System;
using System.Collections.Generic;
using System.Linq;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog.Data.Repository
{
    public class PostRepository : IPostRepository 
    {
        public readonly ApplicationDbContext _context;

        public PostRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Post post) {
            _context.Posts.Add(post);
            _context.SaveChanges();
        }

        // TODO: Get by page numbers
        public List<Post> GetPosts()
        {
            return _context.Posts.Include(p => p.User).ToList();
        }
    }
}
