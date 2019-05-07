using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoryWebsite.Models
{
    public class StoryWebsiteDbContext: IdentityDbContext<ApplicationUser, IdentityRole, string>
    {
        public StoryWebsiteDbContext()
        {
        }

        public StoryWebsiteDbContext(DbContextOptions<StoryWebsiteDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Story> stories { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Comment> comments { get; set; }
        public DbSet<User> users { get; set; }

    }
}
