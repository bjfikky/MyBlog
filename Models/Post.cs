using System;
using System.ComponentModel.DataAnnotations;
using Blog.Data;

namespace Blog.Models
{
    public class Post
    {
        public int Id { get; set; }

        [Required, MaxLength(256)]
        public string Title { get; set; }

        [Required]
        public string Body { get; set; }

        [Required]
        public DateTime DateTime { get; set; }

        public ApplicationUser User { get; set; }
    }
}
