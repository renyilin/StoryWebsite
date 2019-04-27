using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StoryWebsite.Models
{
    public class StorySlide
    {
        [Required]
        [Key]
        public int slideID { get; set; }

        //[Required]
        //public Story story { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Title")]
        public string title { get; set; }

        [Required]
        [Display(Name = "Description")]
        public string description { get; set; }

        public string url { get; set; }
        public string photographer { get; set; }
    }
}
