using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StoryWebsite.Models
{
    public class Comment
    {
        [Required]
        [Key]
        public int commentID { get; set; }

        [Required]
        [StringLength(500)]
        public string content { get; set; }

        [Required]
        public DateTime postTime{ get; set; }

        [Required]
        public bool status { get; set; } //true: allowed to show; false: not allowed;.

        [Required]
        public User author { get; set; }

        [Required]
        public int storyID { get; set; }
    }
}
