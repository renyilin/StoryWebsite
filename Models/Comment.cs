using System;
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
        public bool status { get; set; } //1: allowed to show; 0: not allowed;.

        [Required]
        public int userID { get; set; }

        [Required]
        public int storyID { get; set; }
    }
}
