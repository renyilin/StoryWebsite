using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StoryWebsite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        [HttpGet]
        public ActionResult<IEnumerable<User>> List()
        {
            // in real life - retrieve from database
            var users = new List<User>{
                new User {
                    Id = 1,
                    Name = "RYL",
                    Summary = "36 / Lead Software Developer" },
                new User {
                    Id = 2,
                    Name = "ABC",
                    Summary = "45 / Software Developer" }
            };
            return Ok(users);
        }

        [HttpPost("post", Name ="postUser")]
        public IActionResult List([FromBody] List<Slide> slide)
        {
            return Json(slide);
        }

        [HttpPost("uploadImg", Name = "uploadImg")]
        public async Task<string> UploadAsync([FromForm] IFormFile file)
        {
            var r = Request;
            if (file.Length > 0)
            {
                using (var stream = new FileStream("./wwwroot/" + file.FileName, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
            }

            return JsonConvert.SerializeObject(new { newURL = "/" + file.FileName });
        }
    }


    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Summary { get; set; }
    }

    public class Slide
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string imgURL { get; set; }
    }
}
