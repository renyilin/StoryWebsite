using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StoryWebsite.Models;


namespace StoryWebsite.Services
{
    public class MockDataService : IStory
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

    }
}
