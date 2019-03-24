using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StoryWebsite.Models;
using Microsoft.EntityFrameworkCore;

namespace StoryWebsite.Services
{
    public class StoryService : IStory
    {
        private readonly StoryWebsiteDbContext _ctx;
        public StoryService(StoryWebsiteDbContext ctx)
        {
            _ctx = ctx;
        }

        public void add(Story story)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Story> getAll()
        {
            return _ctx.storys.Include(story => story.category);
        }

        public IEnumerable<Story> getByCategory(Category ctg)
        {
            return getAll().Where(story => story.category.categoryID == ctg.categoryID);
        }

        public Story getById(int id)
        {
            return _ctx.storys.Find(id);
        }

    }
}
