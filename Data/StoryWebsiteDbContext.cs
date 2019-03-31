using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoryWebsite.Models
{
    public class StoryWebsiteDbContext: DbContext
    {
        public StoryWebsiteDbContext()
        {
        }

        public StoryWebsiteDbContext(DbContextOptions<StoryWebsiteDbContext> options) : base(options)
        {

        }

        public DbSet<Story> stories { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Comment> comments { get; set; }
        public DbSet<User> users { get; set; }

    }
}
