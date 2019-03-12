using System;
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
        public string title { get; set; }

        [Required]
        public string content { get; set; }
        public string url { get; set; }

        [Required]
        public Category category { get; set; }

        //[Required]
        //public DateTime createTime{ get; set; }

        //public DateTime updateTime { get; set; }

        //[Required]
        //public bool status { get; set; } // 0: private; 1: public.

        //[Required]
        //public int userID { get; set; }
    }
}
