using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoryWebsite.Models
{
    public class StoryWebsiteDbContext: DbContext
    {
        public StoryWebsiteDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Story> storys { get; set; }
        public DbSet<Category> categories { get; set; }
    }
}
