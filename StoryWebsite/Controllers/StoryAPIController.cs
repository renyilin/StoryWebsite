using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using StoryWebsite.Models;
using StoryWebsite.Services;

namespace StoryWebsite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoryAPIController : ControllerBase
    {
        private readonly IStoryServer _storyService;
        private readonly string _repoPath;
        public StoryAPIController(IStoryServer storyService)
        {
            _storyService = storyService;
            _repoPath = "fileStorage\\images\\";
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> GetStory()
        {
            List<string> res = new List<string>();
            var storys = _storyService.getAll();
            foreach (var s in storys)
            {
                res.Add(s.title);
            }
            return res;
        }

        [HttpGet("{id}")]
        public IEnumerable<string> GetStoryDetail(int id)
        {
            List<string> res = new List<string>();
            var storys = _storyService.getById(id);
            res.Add("ID: " + storys.storyID);
            res.Add("Title: " + storys.title);
            res.Add("Description: " + storys.content);
            res.Add("Category: " + storys.category.categoryName);
            res.Add("Created Time: " + storys.createTime);
            res.Add("Updated Time: " + storys.createTime);
            return res;
        }

        [HttpPost("postStoryBlock", Name = "postStoryBlock")]
        public IActionResult postStoryBlock([FromBody] SlideModel slideModel)
        {
            var story = _storyService.getById(slideModel.storyId);
            var storySlides = new List<StorySlide>();
            for (int i = 0; i < slideModel.slide.Count(); i++) {
                storySlides.Add(new StorySlide() {
                    title = slideModel.slide[i].title,
                    description = slideModel.slide[i].description,
                    url = slideModel.slide[i].imgURL,
                    order = i 
                });
            }
            story.slides = storySlides;
            _storyService.update();
            return Ok("Ok");
        }

        // GET: api/<controller>
        [HttpGet("getStorySlides", Name = "getStorySlides")]
        public ActionResult<IEnumerable<StorySlide>> GetStorySlides(int storyId)
        {
            var story = _storyService.getById(storyId);
            var storySlides = new List<StorySlide>();
            IEnumerable<StorySlide> sortSlides = null;
            if (story != null && story.slides != null) {
                foreach (var v in story.slides){
                    storySlides.Add(new StorySlide()
                    {
                        title = v.title,
                        description = v.description,
                        url = v.url,
                        order = v.order
                    });
                }
                sortSlides = storySlides.OrderBy(s=>s.order);
            }
            return Ok(sortSlides);
        }

        [HttpPost("uploadImg", Name = "uploadImg")]
        public async Task<string> UploadAsync([FromForm] IFormFile file)
        {
            string newFileName = DateTime.Now.ToString("yyyyMMddHHmmss_") + file.FileName;
            string path = (new FileInfo(AppDomain.CurrentDomain.BaseDirectory)).Directory.Parent.Parent.Parent.FullName;
            string filePath = path + "\\wwwroot\\" + _repoPath + newFileName;
            if (file.Length > 0)
            {
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
            }
            return JsonConvert.SerializeObject(new { newURL = "\\" + _repoPath + newFileName });
            }

        public class SlideModel
        {
            public List<Slide> slide { get; set; }
            public int storyId { get; set; }
            
        }

        public class Slide
        {
            public int id { get; set; }
            public string title { get; set; }
            public string description { get; set; }
            public string imgURL { get; set; }
        }

    }
}