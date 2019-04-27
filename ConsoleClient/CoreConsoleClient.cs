///////////////////////////////////////////////////////////////
// ConsoleClient.cs - Client for WebApi FilesController      //
//                                                           //
// Jim Fawcett, CSE686 - Internet Programming, Spring 2019   //
///////////////////////////////////////////////////////////////
/*
 * - Based on Asp.Net Core Framework, this client project generates
 *   dynamic link library that can be hosted by Visual Studio or
 *   dotnet CLI.
 * - It provides options via its command line, e.g.:
 *   - url /fl            displays list of files in server's FileStore
 *   - url /up fileSpec   uploades fileSpec to FileStore
 *   - url /dn n          downloads nth file in FileStore
 *   - url /dl n          deletes nth file in FileStore
 */
using System;
using System.Text;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json.Serialization;  // must install Newtonsoft package from Nuget
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace ConsoleClient
{
  class CoreConsoleClient
  {
    public HttpClient client { get; set; }

    private string baseUrl_;
    private string downloadPath_ = "../../../download/";

    CoreConsoleClient(string url)
    {
      baseUrl_ = url;
      client = new HttpClient();
    }
    //----< upload file >--------------------------------------

    public async Task<HttpResponseMessage> SendFile(string fileSpec)
    {
      MultipartFormDataContent multiContent = new MultipartFormDataContent();

      byte[] data = File.ReadAllBytes(fileSpec);
      ByteArrayContent bytes = new ByteArrayContent(data);
      string fileName = Path.GetFileName(fileSpec);
      multiContent.Add(bytes, "files", fileName);

      return await client.PostAsync(baseUrl_, multiContent);
    }
    //----< get list of files in server FileStorage >----------

    public async Task<IEnumerable<string>> GetFileList()
    {
      HttpResponseMessage resp = await client.GetAsync(baseUrl_);
      var files = new List<string>();
      if (resp.IsSuccessStatusCode)
      {
        var json = await resp.Content.ReadAsStringAsync();
        JArray jArr = (JArray)JsonConvert.DeserializeObject(json);
        foreach (var item in jArr)
          files.Add(item.ToString());
      }
      return files;
    }


    //----< get list of stories in server StoryAPI >----------

    public async Task<IEnumerable<string>> GetStory()
    {
        HttpResponseMessage resp = await client.GetAsync(baseUrl_);
        var stories = new List<string>();
        if (resp.IsSuccessStatusCode)
        {
            var json = await resp.Content.ReadAsStringAsync();
            JArray jArr = (JArray)JsonConvert.DeserializeObject(json);
            foreach (var item in jArr)
               stories.Add(item.ToString());
        }
        return stories;
    }


    public async Task<IEnumerable<string>> GetStoryDetails(int id)
    {
        HttpResponseMessage resp = await client.GetAsync(baseUrl_ + "/" + id.ToString());
        var details = new List<string>();
        if (resp.IsSuccessStatusCode)
        {
            var json = await resp.Content.ReadAsStringAsync();
            JArray jArr = (JArray)JsonConvert.DeserializeObject(json);
            foreach (var item in jArr)
               details.Add(item.ToString());
        }
        return details;
    }

            //----< download the id-th file >--------------------------

     public async Task<HttpResponseMessage> GetFile(int id)
    {
      HttpResponseMessage tdl = await client.GetAsync(baseUrl_ + "/" + id.ToString());
      // Retrieve the website contents from the HttpResponseMessage.
      byte[] bytes = await tdl.Content.ReadAsByteArrayAsync();
      string path = downloadPath_ + tdl.Content.Headers.ContentDisposition.FileName;

        try
        {
            using (FileStream fs = File.Create(path))
            {
                // Create a new stream to write to the file
                BinaryWriter Writer = new BinaryWriter(fs);

                // Writer raw data                
                Writer.Write(bytes);
                Writer.Flush();
                Writer.Close();
            }
        }
        catch
        {
            //...
            //return false;
        }
        return tdl;
    }
    //----< delete the id-th file from FileStorage >-----------

    public async Task<HttpResponseMessage> DeleteFile(int id)
    {
      return await client.DeleteAsync(baseUrl_ + "/" + id.ToString());
    }
    //----< usage message shown if command line invalid >------

    static void showUsage()
    {
      Console.Write("\n  Command line syntax error: expected usage:\n");
      Console.Write("\n    http[s]://machine:port /option [filespec]\n\n");
    }
    //----< validate the command line >------------------------

    static bool parseCommandLine(string[] args)
    {
      if(args.Length < 2)
      {
        showUsage();
        return false;
      }
      if(args[0].Substring(0,4) != "http")
      {
        showUsage();
        return false;
      }
      if(args[1][0] != '/')
      {
        showUsage();
        return false;
      }
      return true;
    }
    //----< display command line arguments >-------------------

    static void showCommandLine(string[] args)
    {
      string arg0 = args[0];
      string arg1 = args[1];
      string arg2;
      if (args.Length == 3)
        arg2 = args[2];
      else
        arg2 = "";
      Console.Write("\n  CommandLine: {0} {1} {2}", arg0, arg1, arg2);
    }

    static void Main(string[] args)
    {
      Console.Write("\n  CoreConsoleClient");
      Console.Write("\n ===================\n");

      if(!parseCommandLine(args))
      {
        return;
      }
      Console.Write("Press key to start: ");
      Console.ReadKey();

      string url = args[0];
      CoreConsoleClient client = new CoreConsoleClient(url);

      showCommandLine(args);
      Console.Write("\n  sending request to {0}\n", url);

      
      switch (args[1])
      {
        case "/fl":
          Task<IEnumerable<string>> tfl = client.GetFileList();
          var resultfl = tfl.Result;
          foreach (var item in resultfl)
          {
            Console.Write("\n  {0}", item);
          }
          break;
        case "/up":
          Task<HttpResponseMessage> tup = client.SendFile(args[2]);
          Console.Write(tup.Result);
          break;
        case "/dn":
          int id = Int32.Parse(args[2]);
          Task<HttpResponseMessage> tdn = client.GetFile(id);
          Console.Write(tdn.Result);
          break;
        case "/dl":
          int id0 = Int32.Parse(args[2]);
          Task <HttpResponseMessage> tdl = client.DeleteFile(id0);
          Console.Write(tdl.Result);
          break;
        case "/getStory":
          Task<IEnumerable<string>> stl = client.GetStory();
          var resulstl = stl.Result;
          foreach (var item in resulstl)
          {
            Console.Write("\n  {0}", item);
          }
          break;
        case "/getDetails":
          Task<IEnumerable<string>> sdt = client.GetStoryDetails(Int32.Parse(args[2]));
          var resulsdt = sdt.Result;
          foreach (var item in resulsdt)
          {
             Console.Write("\n  {0}", item);
          }
          break;
      }
     
      Console.WriteLine("\n  Press Key to exit: ");
      Console.ReadKey();
    }
  }
}
