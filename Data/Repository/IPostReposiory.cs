using System;
using Blog.Models;

namespace Blog.Data.Repository
{
    public interface IPostRepository
    {
        void Add(Post post);
    }
}
