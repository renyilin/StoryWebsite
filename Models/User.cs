using System;
using System.ComponentModel.DataAnnotations;

namespace StoryWebsite.Models
{
    public class User
    {
        [Required]
        [Key]
        public int userID { get; set; }

        [Required]
        [StringLength(30)]
        public string userName { get; set; }

        [Required]
        [StringLength(200)]
        public string password { get; set; }

        [Required]
        [StringLength(50)]
        public string email { get; set; }

        public string avatarURL { get; set; }
    }
}
