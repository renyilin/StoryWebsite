using StoryWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoryWebsite.Services
{
    public interface IStoryServer
    {
        IEnumerable<Story> getAll();
        IEnumerable<Story> getByCategory(Category ctg);
        Story getById(int id);
        void add(Story story);
        void addComment(int storyID, Comment cm);
        void update();
        void deleteStory(int storyID);


    }
}
