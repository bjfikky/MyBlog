using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Data;
using Blog.Data.Repository;
using Blog.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Blog.Controllers
{
    [Authorize]
    public class PostController : Controller
    {
        protected UserManager<ApplicationUser> _userManager;
        private readonly IPostRepository _postRepository;

        public PostController(
            UserManager<ApplicationUser> userManager, 
            DbContextOptions<ApplicationDbContext> contextOptions,
            IPostRepository postRepository
        )
        {
            _userManager = userManager;
            _postRepository = postRepository;

        }


        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Add() 
        {
            return View();
        }


        [HttpPost]
        public IActionResult Add(Post post)
        {
            if(ModelState.IsValid) {
                var userId = _userManager.GetUserId(HttpContext.User);
                ApplicationUser applicationUser = _userManager.FindByIdAsync(userId).Result;

                post.DateTime = DateTime.Now;
                post.UserId = applicationUser.Id;

                _postRepository.Add(post);
                
                return RedirectToAction("Index", "Home");
            }

            
            return View(post);
        }
    }
}
