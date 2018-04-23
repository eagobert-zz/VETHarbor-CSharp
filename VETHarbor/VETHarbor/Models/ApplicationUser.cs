using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace VETHarbor.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser <Guid>
    {


        //UserId, UserName, Email, & RoleId are inherited from ASP.net identity user

        //Add properties for the user's organization
        public string OrgId { get; set; }
        public string OrgName { get; set; }
        public string OrgCity { get; set; }
        public string OrgState { get; set; }
        public Organization Organization { get; set; }

        public virtual ICollection<IdentityUserRole<Guid>> Roles { get; private set; }



    }
}
