///////////////////////////////////////////////////////////////
// FilesController.cs - Web Api for handling Files           //
//                                                           //
// Jim Fawcett, CSE686 - Internet Programming, Spring 2019   //
///////////////////////////////////////////////////////////////
/*
 * This package implements Controller for Files Web Api.
 * The web api application:
 * - uploads files to wwwroot/FileStore
 * - displays all files in FileStore
 * - downloads a file from FileStore
 * - [will] delete a file, given its index, from FileStore
 * 
 * Note that Web Api applications don't use action names in their urls.
 * Instead, they use GET, POST, PUT, and DELETE based on the type of
 * the HTTP Request Message.  Also, they don't return views.  They
 * return data.
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;
//using WebApiLect13.Models;

namespace WebApiLect13.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilesController : ControllerBase
    {
        private readonly IHostingEnvironment hostingEnvironment_;
        private string webRootPath = null;
        private string filePath = null;

        public FilesController(IHostingEnvironment hostingEnvironment)
        {
            hostingEnvironment_ = hostingEnvironment;
            webRootPath = hostingEnvironment_.WebRootPath;
            filePath = Path.Combine(webRootPath, "FileStorage");
        }
        ////----< show files in wwwroot/FileStorage >----------------
        //
        // Not quite functional attempt to make GetFiles asynchronous
        //
        //private List<string> GetFilesHelper(string filePath)
        //{
        //  List<string> files = null;
        //  try
        //  {
        //    files = Directory.GetFiles(filePath).ToList<string>();
        //    for (int i = 0; i < files.Count; ++i)
        //      files[i] = Path.GetFileName(files[i]);
        //  }
        //  catch
        //  {
        //    files = new List<string>();
        //    files.Add("404 - Not Found");
        //  }
        //  return files;
        //}

        // GET: api/<controller>
        //[HttpGet]
        //public async Task<List<string>> Get()
        //{
        //  List<string> files = await GetFilesHelper(filePath);
        //  return files;
        //}
        //----< show files in wwwroot/FileStorage >----------------
        //
        // The Core Framework will serialize the return value into
        // a JSon string in the Response message body.

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            List<string> files = null;
            try
            {
                files = Directory.GetFiles(filePath).ToList<string>();
                for (int i = 0; i < files.Count; ++i)
                    files[i] = Path.GetFileName(files[i]);
            }
            catch
            {
                files = new List<string>();
                files.Add("404 - Not Found");
            }
            return files;
        }
        //----< download single file in wwwroot\FileStorage >------

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Download(int id)
        {
            List<string> files = null;
            string file = "";
            try
            {
                files = Directory.GetFiles(filePath).ToList<string>();
                if (0 <= id && id < files.Count)
                    file = Path.GetFileName(files[id]);
                else
                    return NotFound();
            }
            catch
            {
                return NotFound();
            }
            var memory = new MemoryStream();
            file = files[id];
            using (var stream = new FileStream(file, FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            return File(memory, GetContentType(file), Path.GetFileName(file));
        }
        private string GetContentType(string path)
        {
            var types = GetMimeTypes();
            var ext = Path.GetExtension(path).ToLowerInvariant();
            return types[ext];
        }

        private Dictionary<string, string> GetMimeTypes()
        {
            return new Dictionary<string, string>
      {
        {".cs", "application/C#" },
        {".txt", "text/plain"},
        {".pdf", "application/pdf"},
        {".doc", "application/vnd.ms-word"},
        {".docx", "application/vnd.ms-word"},
        {".xls", "application/vnd.ms-excel"},
        {".xlsx", "application/vnd.openxmlformatsofficedocument.spreadsheetml.sheet"},
        {".png", "image/png"},
        {".jpg", "image/jpeg"},
        {".jpeg", "image/jpeg"},
        {".gif", "image/gif"},
        {".csv", "text/csv"}
      };
        }
        //----< upload file >--------------------------------------

        // POST api/<controller>
        [HttpPost]
        public async Task<IActionResult> Upload()
        {
            var request = HttpContext.Request;
            foreach (var file in request.Form.Files)
            {
                if (file.Length > 0)
                {
                    var path = Path.Combine(filePath, file.FileName);
                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(fileStream);
                    }
                }
                else
                {
                    return BadRequest();
                }
            }
            return Ok();
        }

        //// POST api/<controller>
        //// This is the usual technique for uploading files, but I never got more than
        //// one file.  Something wrong with the configuration of my IFormFile model?
        //
        //[HttpPost]
        //public async Task<IActionResult> Post(IList<IFormFile> files)
        //{
        //  var dummy = HttpContext.Request;  // statement for debugging
        //  foreach (var file in files)
        //  {
        //    if (file.Length > 0)
        //    {
        //      var path = Path.Combine(filePath, file.FileName);
        //      using (var fileStream = new FileStream(path, FileMode.Create))
        //      {
        //        await file.CopyToAsync(fileStream);
        //      }
        //    }
        //  }
        //  return Ok();
        //}

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
            // ToDo
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // ToDo
            List<string> files = null;
            string file = "";
            try
            {
                files = Directory.GetFiles(filePath).ToList<string>();
                if (0 <= id && id < files.Count)
                {
                    file = Path.GetFileName(files[id]);
                    var path = Path.Combine(filePath, file);
                    System.IO.File.Delete(path);
                }
                else {
                    return NotFound();
                }
            }
            catch
            {
                return NotFound();
            }
            return Ok();
        }
    }
}
