using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StoryWebsite.Models;


namespace StoryWebsite.Services
{
    public class MockDataService : IStoryServer
    {
        public IEnumerable<Story> getAll()
        {
            StoryList storyList = StoryList.getInstance();
            return storyList;
        }

        public IEnumerable<Story> getByCategory(Category ctg)
        {
            throw new NotImplementedException();
        }

        public Story getById(int id)
        {
            StoryList storyList = StoryList.getInstance();
            return storyList[id];
        }

        public void add(Story story)
        {
            StoryList storyList = StoryList.getInstance();
            storyList.add(story);
        }

        public void addComment(int storyID, Comment cm)
        {
            throw new NotImplementedException();
        }

        public void update()
        {
            throw new NotImplementedException();
        }

        public void deleteStory(int storyID)
        {
            throw new NotImplementedException();
        }
    }
}
