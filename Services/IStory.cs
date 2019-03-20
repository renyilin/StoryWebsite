using StoryWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoryWebsite.Services
{
    public interface IStory
    {
        IEnumerable<Story> getAll();
        IEnumerable<Story> getByCategory(Category ctg);
        Story getById(int id);
        

    }
}
