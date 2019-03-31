/*
 ----------------------------------------------------------------
  Startup.cs - Here's where MVC services are configured
  ver 1.0
  Jim Fawcett, CSE686 - Internet Programming, Spring 2019
 ----------------------------------------------------------------
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
//using StoryWebsite.Models
using Microsoft.Extensions.Configuration;
using StoryWebsite.Models;
using StoryWebsite.Services;

namespace StoryWebsite
{
  public class Startup
  {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, 
        // visit https://go.microsoft.com/fwlink/?LinkID=398940
     public IConfiguration _configuration { get;}
     public Startup(IConfiguration configuration)
     {
         _configuration = configuration;
     }

    public void ConfigureServices(IServiceCollection services)
    {
      services.AddScoped<IStory, StoryService>();
      services.AddMvc();

      services.AddDbContext<StoryWebsiteDbContext>(options =>
            options.UseSqlServer(
        _configuration.GetConnectionString("DefaultConnection")));
        }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.

    public void Configure(IApplicationBuilder app, IHostingEnvironment env, StoryWebsiteDbContext dbcontext)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }



      app.UseStaticFiles();  // needed to load css and js

      //app.UseMvcWithDefaultRoute();
      app.UseMvc(routes =>
      {
        routes.MapRoute(
          name: "default",
          template: "{Controller=Story}/{action=Index}/{id?}"
        );
      });


                //dbcontext.Database.EnsureCreated();

                //var testBlog = dbcontext.categories.FirstOrDefault(b => b.categoryName == "People");
                //if (testBlog == null)
                //{
                //    dbcontext.categories.Add(new Category { categoryName = "People" });
                //}
                //dbcontext.SaveChanges();

            //----< if we get here, there is a problem >---------------
            app.Run(async (context) =>
      {
        await context.Response.WriteAsync("Server Error!");
      });
    }
  }
}
