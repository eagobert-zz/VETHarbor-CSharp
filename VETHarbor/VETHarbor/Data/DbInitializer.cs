using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VETHarbor.Models;

//This file seeds data to the database.  Creating roles at startup.

namespace VETHarbor.Data
{

    public class DbInitializer
    {
        //public static async Task CreateRoles(IServiceProvider serviceProvider, IConfiguration Configuration)
        //{
            
        //    var RoleManager = serviceProvider.GetRequiredService<RoleManager<ApplicationRole>>();
        //    var UserManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();


        //    //adding custom roles
        //    string[] roleNames = { "User", "Administrator" };
        //    IdentityResult roleResult;

        //    foreach (var Name in roleNames)
        //    {
        //        // creating the roles and seeding them to the database
        //        var roleExist = await RoleManager.RoleExistsAsync(Name);
        //        if (!roleExist)
        //        {
        //            roleResult = await RoleManager.CreateAsync(new ApplicationRole(Name));

        //        }
        //    }

        //    //adding Admin User
        //    var user = new ApplicationUser
        //    {
        //        UserName = "admin@VETHarbor.com",
        //        UserAddress = "123 Fake Street",
        //        UserCity = "Nashville",
        //        UserState = "TN",
        //        UserZip = "37076",
        //        Email = "admin@VETHarbor.com"
        //    };
        //}

    }
}
