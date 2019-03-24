using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StoryWebsite.Models
{
    public class Story
    {
        [Required]
        [Key]
        public int stroyID { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Title")]
        public string title { get; set; }

        [Required]
        [Display(Name = "Description")]
        public string content { get; set; }

        public string url { get; set; }

        [Required]
        [Display(Name = "Category")]
        public Category category { get; set; }

        [Required]
        [Display(Name = "Create Date")]
        public DateTime createTime{ get; set; }

        public DateTime updateTime { get; set; }

        [Required]
        public bool status { get; set; } // 0: private; 1: public.

        [Required]
        [Display(Name = "Author")]
        public User author { get; set; }

        public IEnumerable<Comment> comments { get; set; }
    }
}
