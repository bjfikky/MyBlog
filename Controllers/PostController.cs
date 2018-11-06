using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Data;
using Blog.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Blog.Controllers
{

public class PostController : Controller
    {
        protected UserManager<ApplicationUser> _userManager;

        public PostController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
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
            var userId = _userManager.GetUserId(HttpContext.User);
            ApplicationUser applicationUser = _userManager.FindByIdAsync(userId).Result;

            post.DateTime = DateTime.Now;
            post.User = applicationUser;
            
            return View();
        }
    }
}
