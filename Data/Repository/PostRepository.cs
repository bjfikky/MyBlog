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

        public List<Post> GetPosts()
        {
            return _context.Posts.ToList();
        }
    }
}
