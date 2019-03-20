using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StoryWebsite.Services;
using StoryWebsite.ViewModels;

namespace StoryWebsite.Controllers
{
    public class StoryController : Controller
    {
        private readonly IStory _storyService;

        public StoryController(IStory storyService)
        {
            _storyService = storyService;
        }

        public IActionResult Index()
        {
            var storys = _storyService.getAll();
            StoryIndexViewModel storyIndexViewModel = new StoryIndexViewModel {
                StoryCollection = storys,
                title = "Story Index"
            };
            return View(storyIndexViewModel);
        }

        public IActionResult Details(int id) {
            var story = _storyService.getById(id);
            return View(story);
        }

        public IActionResult About()
        {
            return View();
        }
    }
}