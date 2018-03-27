using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace VETHarbor.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser <Guid>
    {
        //UserId, UserName, Email, & RoleId are inherited from identity user
        public int? OrgId { get; set; }
        public int? UserEventId { get; set; }



        public virtual ICollection<IdentityUserRole<Guid>> Roles { get; private set; }
       // public virtual ICollection<UserEvents> UserEvents { get; set; }

    }
}
