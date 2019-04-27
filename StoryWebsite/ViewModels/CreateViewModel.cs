using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StoryWebsite.Models
{
    public class CreateViewModel
    {

        public Story story { get; set; }

        [Required]
        [Display(Name = "Cover Image")]
        public IFormFile coverImage { get; set; }
    }
}
