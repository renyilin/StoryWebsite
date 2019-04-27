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
        private readonly IStoryServer _storyService;
        private readonly string _repoPath;

        public StoryController(IStoryServer storyService)
        {
            _storyService = storyService;
            _repoPath = "/fileStorage/images/";
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

        public IActionResult Show(int id)
        {
            var story = _storyService.getById(id);
            return View(story);
        }


        //----< gets form for creating a course >--------------------

        [HttpGet]
        public IActionResult Create(int id)
        {
            CreateViewModel createViewModel = new CreateViewModel()
            {
                story = new Story(),
                coverImage = null
            }; 

            return View(createViewModel);
        }
        //----< posts back new courses details >---------------------

        [HttpPost]
        public async Task<IActionResult> Create(int id, CreateViewModel createViewModel)
        {
            IFormFile img = createViewModel.coverImage;
            string newFileName = DateTime.Now.ToString("yyyyMMddHHmmss_") + img.FileName;
            string filePath = Directory.GetCurrentDirectory() + "/wwwroot/" + _repoPath
                                + newFileName;
            await Upload(img, filePath);
            createViewModel.story.createTime = DateTime.Now;

            //Temporary avatarURL & password
            createViewModel.story.author.avatarURL = "https://lucidchart.zendesk.com/system/photos/8933/3314/profile_image_678269360_201415.png";
            createViewModel.story.author.password = "admin12345";
            createViewModel.story.author.email = "123@sina.com";
            createViewModel.story.url = _repoPath + newFileName;

            _storyService.add(createViewModel.story);
            return RedirectToAction("index");
        }

        //[HttpPost]
        public async Task<IActionResult> Upload(IFormFile formFile, string filePath)
        {
            if (formFile.Length > 0)
            {
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await formFile.CopyToAsync(stream);
                }
            }
            return Ok();
        }

        [HttpPost]
        public IActionResult AddComment(int id, Comment cm)
        {
            var storys = _storyService.getAll();
            var st = storys.FirstOrDefault(a => a.storyID == id);
            cm.story = st;
            cm.author = st.author;  //demo data  --> will be replaced by current user
            cm.postTime = DateTime.Now;

            _storyService.addComment(id, cm);

            //var newComment = new Comment() {


            //};
            return RedirectToAction("details", new {id = id});
        }

        public IActionResult DeleteComment(int storyID, int commentID)
        {

            _storyService.deleteComment(storyID, commentID);

            return RedirectToAction("details", new { id = storyID });
        }

        [HttpGet]
        public IActionResult EditStory(int storyID)
        {
            var story = _storyService.getById(storyID);
            return View(story);
        }

        [HttpPost]
        public IActionResult EditStory(Story story)
        {
            var newStory = _storyService.getById(story.storyID);
            newStory.title = story.title;
            newStory.url = story.url;
            newStory.content = story.content;
            newStory.category = story.category;
            newStory.updateTime = DateTime.Now;
            _storyService.update();

            return RedirectToAction("details", new { id = newStory.storyID });
        }

        public IActionResult DeleteStory(int storyID) {
            _storyService.deleteStory(storyID);
            return RedirectToAction("Index");
        }


        public IActionResult About()
        {
            return View();
        }
    }
}