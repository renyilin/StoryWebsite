using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoryWebsite.Models
{
    public class ApplicationUser:IdentityUser
    {
        public ApplicationUser() : base() { }
        public string fullName { get; set; }
        public string avatarURL { get; set; }
    }
}
