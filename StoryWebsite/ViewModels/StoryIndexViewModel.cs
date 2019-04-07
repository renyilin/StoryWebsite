using StoryWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoryWebsite.ViewModels
{
    public class StoryIndexViewModel
    {
        public IEnumerable<Story> StoryCollection { get; set; }
        public string title { get; set; }
    }
}
