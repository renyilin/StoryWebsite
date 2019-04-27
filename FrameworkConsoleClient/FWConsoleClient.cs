///////////////////////////////////////////////////////////////
// FWConsoleClient.cs - Client for WebApi FilesController    //
//                                                           //
// Jim Fawcett, CSE686 - Internet Programming, Spring 2019   //
///////////////////////////////////////////////////////////////
/*
 * - Based on Asp.Net Framework, this client project generates
 *   executable (exe) that can be run from the command prompt.
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
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace ConsoleClient
{
  using Dispatcher = Dictionary<string, Func<string, int, Task<HttpResponseMessage>>>;

  class CoreConsoleClient
  {
    public HttpClient client { get; set; }

    private string baseUrl_;

    CoreConsoleClient(string url)
    {
      baseUrl_ = url;
      client = new HttpClient();
    }

    public async Task<HttpResponseMessage> SendFile(string fileSpec)
    {
      MultipartFormDataContent multiContent = new MultipartFormDataContent();

      byte[] data = File.ReadAllBytes(fileSpec);
      ByteArrayContent bytes = new ByteArrayContent(data);
      string fileName = Path.GetFileName(fileSpec);
      multiContent.Add(bytes, "files", fileName);

      return await client.PostAsync(baseUrl_, multiContent);
    }

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

    public async Task<HttpResponseMessage> GetFile(int id)
    {
      return await client.GetAsync(baseUrl_ + "/" + id.ToString());
    }

    public async Task<HttpResponseMessage> DeleteFile(int id)
    {
      return await client.DeleteAsync(baseUrl_ + "/" + id.ToString());
    }

    //static Dispatcher createDispatcher(CoreConsoleClient client)
    //{
    //  Dispatcher disp 
    //    = new Dispatcher();
    //  disp.Add("/fl", (string s, int i) => { return client.GetFileList(); });
    //  disp.Add("/up", (string fileSpec, int i) => { return client.SendFile(fileSpec); });
    //  disp.Add("/dn", (string s, int i) => { return client.GetFile(i); });
    //  disp.Add("/dl", (string s, int i) => { return client.DeleteFile(i); });
    //  return disp;
    //}

    static void showUsage()
    {
      Console.Write("\n  Command line syntax error: expected usage:\n");
      Console.Write("\n    http[s]://machine:port /option [filespec]\n\n");
    }

    static bool parseCommandLine(string[] args)
    {
      if (args.Length < 2)
      {
        showUsage();
        return false;
      }
      if (args[0].Substring(0, 4) != "http")
      {
        showUsage();
        return false;
      }
      if (args[1][0] != '/')
      {
        showUsage();
        return false;
      }
      return true;
    }

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

      if (!parseCommandLine(args))
      {
        return;
      }
      Console.Write("Press key to start: ");
      Console.ReadKey();

      //string url = "https://localhost:44342/api/Files";
      string url = args[0];

      CoreConsoleClient client = new CoreConsoleClient(url);
      //Dispatcher disp = createDispatcher(client);

      showCommandLine(args);
      Console.Write("\n  sending request to {0}\n", url);

      switch (args[1])
      {
        case "/fl":
          Task<IEnumerable<string>> tfl = client.GetFileList();
          //Task<HttpResponseMessage> t = disp[args[1]](param1, param2);
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
          break;
      }

      Console.WriteLine("\n  Press Key to exit: ");
      Console.ReadKey();
    }
  }
}
