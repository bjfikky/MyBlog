using System;
using System.Collections.Generic;
using System.Linq;
using Blog.Models;

namespace Blog.Data.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        readonly ApplicationDbContext _context;

        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
            _context.Dispose();
        }

        public List<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }
    }
}