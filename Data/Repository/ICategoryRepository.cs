using System;
using System.Collections.Generic;
using Blog.Models;

namespace Blog.Data.Repository
{
    public interface ICategoryRepository
    {
        void Add(Category category);
        List<Category> GetCategories();
    }
}
