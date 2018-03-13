using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace VETHarbor.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser<Guid>
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string UserCity { get; set; }
        public string UserState { get; set; }
    }
}
