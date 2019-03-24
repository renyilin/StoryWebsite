using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StoryWebsite.Models;
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

        //----< gets form for creating a course >--------------------

        [HttpGet]
        public IActionResult Create(int id)
        {
            var storys = _storyService.getAll();
            var model = new Story();
           //model.stroyID = storys.Count() + 1;
            return View(model);
        }
        //----< posts back new courses details >---------------------

        [HttpPost]
        public IActionResult Create(int id, Story story)
        {
            var storys = _storyService.getAll();
            story.createTime = DateTime.Now;
            story.stroyID = storys.Count();
            _storyService.add(story);
            return RedirectToAction("index");
        }

        [HttpPost]
        public async Task<IActionResult> Upload(List<IFormFile> files)
        {
            var formFile = files[0];
            var filePath = Directory.GetCurrentDirectory() + "/Repository/Images/" 
                           + formFile.FileName;

            if (formFile.Length > 0)
            {
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await formFile.CopyToAsync(stream);
                }
            }
            return Ok();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}