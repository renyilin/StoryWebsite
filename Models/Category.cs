using System;
using System.ComponentModel.DataAnnotations;

namespace StoryWebsite.Models
{
    public class Category
    {
        [Required]
        [Key]
        public int categoryID { get; set; }

        [Required]
        [StringLength(30)]
        public string categoryName { get; set; }
    }
}