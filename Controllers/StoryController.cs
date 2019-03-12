using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StoryWebsite.ViewModels;

namespace StoryWebsite.Controllers
{
    public class StoryController : Controller
    {
        public IActionResult Index()
        {
            StoryIndexViewModel storyIndexViewModel = new StoryIndexViewModel {
                title = "Story Index"
            };
            return View(storyIndexViewModel);
        }
    }
}