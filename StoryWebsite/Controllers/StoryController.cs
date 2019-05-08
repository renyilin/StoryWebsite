using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
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
        private readonly UserManager<ApplicationUser> _userManager;

        public StoryController(IStoryServer storyService, UserManager<ApplicationUser> userManager)
        {
            _storyService = storyService;
            _repoPath = "fileStorage\\images\\";
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var storys = _storyService.getAll().OrderByDescending(s => s.createTime);
            StoryIndexViewModel storyIndexViewModel = new StoryIndexViewModel {
                StoryCollection = storys,
                title = "Story Index"
            };
            return View(storyIndexViewModel);
        }

        public IActionResult Details(int id) {
            var story = _storyService.getById(id);
            var userId = _userManager.GetUserId(HttpContext.User);
            ViewData["isAuthor"] = false;
            if (userId == story.author.Id)
            {
                ViewData["isAuthor"] = true;
            }
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
            string path = (new FileInfo(AppDomain.CurrentDomain.BaseDirectory)).Directory.Parent.Parent.Parent.FullName;
            string filePath = path + "\\wwwroot\\" + _repoPath + newFileName;
            await Upload(img, filePath);
            createViewModel.story.createTime = DateTime.Now;

            createViewModel.story.author = await _userManager.GetUserAsync(User);
            createViewModel.story.url = "\\"+ _repoPath + newFileName;

            _storyService.add(createViewModel.story);
            return RedirectToAction("editStoryBlock", new { storyId = createViewModel.story.storyID });
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
        public async Task<IActionResult> AddComment(int id, Comment cm)
        {
            var storys = _storyService.getAll();
            var st = storys.FirstOrDefault(a => a.storyID == id);
            cm.story = st;
            cm.author = await _userManager.GetUserAsync(User);
            cm.postTime = DateTime.Now;
            _storyService.addComment(id, cm);
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
            var userId = _userManager.GetUserId(HttpContext.User);
            var story = _storyService.getById(storyID);
            ViewData["isAuthor"] = false;
            if (userId == story.author.Id || User.IsInRole("Admin"))
            {
                ViewData["isAuthor"] = true;

                CreateViewModel createViewModel = new CreateViewModel()
                {
                    story = story,
                    coverImage = null
                };
                return View(createViewModel);
            }
            else {
                return View("index");
            }
        }

        [HttpPost]
        public async Task<IActionResult> EditStory(CreateViewModel createViewModel)
        {
            var newStory = _storyService.getById(createViewModel.story.storyID);
            IFormFile img = createViewModel.coverImage;
            if(img != null)
            {
                string newFileName = DateTime.Now.ToString("yyyyMMddHHmmss_") + img.FileName;
                string path = (new FileInfo(AppDomain.CurrentDomain.BaseDirectory)).Directory.Parent.Parent.Parent.FullName;
                string filePath = path + "\\wwwroot\\" + _repoPath + newFileName;
                await Upload(img, filePath);
                createViewModel.story.url = "\\" + _repoPath + newFileName;
                newStory.url = createViewModel.story.url;
            }
            
            newStory.title = createViewModel.story.title;
            newStory.content = createViewModel.story.content;
            newStory.category = createViewModel.story.category;
            newStory.updateTime = DateTime.Now;
            _storyService.update();

            return RedirectToAction("EditStoryBlock", new { storyID = newStory.storyID });
        }

        [Authorize(Roles = "Admin")]
        public IActionResult DeleteStory(int storyID) {
            _storyService.deleteStory(storyID);
            return RedirectToAction("Index");
        }

        public IActionResult EditStoryBlock(int storyID)
        {
            var story = _storyService.getById(storyID);
            return View(story);
        }

        public IActionResult About()
        {
            return View();
        }
    }
}