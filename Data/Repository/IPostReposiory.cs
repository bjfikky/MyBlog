using System;
using System.Collections.Generic;
using Blog.Models;

namespace Blog.Data.Repository
{
    public interface IPostRepository
    {
        void Add(Post post);
        List<Post> GetPosts();
    }
}
