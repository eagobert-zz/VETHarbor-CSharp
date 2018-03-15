using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace VETHarbor.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser<Guid>
    {

        public string UserAddress { get; set; }
        public string UserCity { get; set; }
        public string UserState { get; set; }
        public string UserZip { get; set; }

        public string RoleName { get; set; }
        public ApplicationRole ApplicationRole { get; set; }

        //Represents a collection of user saved roles
        public virtual ICollection<ApplicationRole> ApplicationRoles { get; set; }

    }
}
