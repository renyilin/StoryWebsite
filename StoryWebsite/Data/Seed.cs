using System;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StoryWebsite.Models;

namespace AuthFull.Data
{
    public static class Seed
    {
        public static async Task CreateRoles(IServiceProvider serviceProvider, IConfiguration Configuration)
        {
            //adding customs roles
            var RoleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var UserManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            var SignInManager= serviceProvider.GetRequiredService<SignInManager<ApplicationUser>>();
            string[] roleNames = { "Admin","User"};
            IdentityResult roleResult;

            foreach (var roleName in roleNames)
            {
                //creating the roles and seeding them to the database
                var roleExist = await RoleManager.RoleExistsAsync(roleName);
                if (!roleExist)
                {
                    roleResult = await RoleManager.CreateAsync(new IdentityRole(roleName));
                }
            }

            //creating a super user who could maintain the web app
            var poweruser = new ApplicationUser
            {
                UserName = Configuration.GetSection("AppSettings")["UserEmail"],
                Email = Configuration.GetSection("AppSettings")["UserEmail"],
                fullName = Configuration.GetSection("AppSettings")["FullName"],
                avatarURL = "https://lucidchart.zendesk.com/system/photos/0003/8356/6346/profile_image_5463430483_201415.png"
            };

            var normaluser = new ApplicationUser
            {
                UserName = "yren20@syr.edu",
                Email = "yren20@syr.edu",
                fullName = "Yilin Ren",
                avatarURL = "https://lucidchart.zendesk.com/system/photos/3602/4496/7872/profile_image_380771567512_201415.png"
            };

            string userPassword = Configuration.GetSection("AppSettings")["UserPassword"];
            var user = await UserManager.FindByEmailAsync(Configuration.GetSection("AppSettings")["UserEmail"]);

            if(user == null)
            {
                var createPowerUser = await UserManager.CreateAsync(poweruser, userPassword);
                var createNormalUser = await UserManager.CreateAsync(normaluser, userPassword);
                if (createPowerUser.Succeeded)
                {
                    //here we tie the new user to the "Admin" role 
                    await UserManager.AddToRoleAsync(poweruser, "Admin");
                    
                }
                if (createNormalUser.Succeeded)
                {
                    await UserManager.AddToRoleAsync(poweruser, "User");
                }
                }
        }
    }
}