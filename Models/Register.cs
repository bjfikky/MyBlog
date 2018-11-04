using System;
using System.ComponentModel.DataAnnotations;

namespace Blog.Models
{
    public class Register
    {
        public string Username { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [MinLength(7, ErrorMessage = "Password must be at least 7 characters")]
        public string Password { get; set; }

        [Display(Name = "Confirm Password"), Compare("Password", ErrorMessage = "Your passwords do not match")]
        public string ConfirmPassword { get; set; }
    }
}
