using System;
using System.ComponentModel.DataAnnotations;

namespace Blog.Models
{
    public class Login
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        // TODO: Add rememeber me?
    }
}
