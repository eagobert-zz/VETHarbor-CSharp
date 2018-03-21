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

    //public static class DbInitializer
    //{
    //    public static async Task Initialize(IServiceProvider serviceProvider, IConfiguration Configuration)
    //    {
    //        var context = serviceProvider.GetRequiredService<ApplicationDbContext>();
    //        {
    //            // Look for any organizations.
    //            if (context.Organizations.Any())
    //            {
    //                return;   // DB has been seeded
    //            }

    //            context.Organizations.AddRange(
    //                 new Organization
    //                 {
                           
    //                       OrganizationName = "VETHarbor",
    //                       OrganizationAddress = "123 Fake Street",
    //                       OrganizationCity = "Nashville",
    //                       OrganizationState = "TN",
    //                 },
    //               new Organization
    //               {
    //                   OrganizationName = "Atlanta Veteran's Affairs",
    //                   OrganizationAddress = "123 Fake Street",
    //                   OrganizationCity = "Atlanta",
    //                   OrganizationState = "GA",
    //               }
    //            );
    //          //  context.SaveChanges();
    //        }
    //    }
    //}
}
