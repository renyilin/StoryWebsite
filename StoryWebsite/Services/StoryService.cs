using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StoryWebsite.Models;
using Microsoft.EntityFrameworkCore;

namespace StoryWebsite.Services
{
    public class StoryService : IStoryServer
    {
        private readonly StoryWebsiteDbContext _ctx;
        public StoryService(StoryWebsiteDbContext ctx)
        {
            _ctx = ctx;
        }

        public void add(Story story)
        {
            _ctx.stories.Add(story);
            _ctx.SaveChanges();
        }

        public void addComment(int storyID, Comment cm)
        {
            _ctx.stories.Find(storyID).comments.Append(cm);
            _ctx.comments.Add(cm);
            try
            {
                _ctx.SaveChanges();
            }
            catch (Exception)
            {
                // do nothing for now
            }
        }

        public void deleteComment(int storyID, int commentID) {
            _ctx.comments.Remove(_ctx.comments.Find(commentID));
            _ctx.SaveChanges();
        }

        public void update() {
            _ctx.SaveChanges();
        }


        public IEnumerable<Story> getAll()
        {
            return _ctx.stories.Include(story => story.category)
                .Include(story => story.author)
                .Include(story => story.comments)
                    .ThenInclude(comment => comment.author);
        }

        public IEnumerable<Story> getByCategory(Category ctg)
        {
            return getAll().Where(story => story.category.categoryID == ctg.categoryID);
        }

        public Story getById(int id)
        {
            return getAll().FirstOrDefault(a => a.storyID == id);
        }

        public void deleteStory(int storyID)
        {
            var story = getAll().FirstOrDefault(a => a.storyID == storyID);

            if (story != null)
            {
                foreach (var cm in story.comments)
                {
                    _ctx.comments.Remove(cm);
                }
                _ctx.stories.Remove(story);
            }
            _ctx.SaveChanges();
        }
    }
}
