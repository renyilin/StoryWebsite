using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StoryWebsite.Services;

namespace StoryWebsite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoryAPIController : ControllerBase
    {
        private readonly IStoryServer _storyService;
        public StoryAPIController(IStoryServer storyService)
        {
            _storyService = storyService;
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

    }
}