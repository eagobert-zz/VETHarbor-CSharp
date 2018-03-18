using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VETHarbor.Models
{
    public class ApplicationUserRole: IdentityUserRole<string>
    {

        public override string UserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

        public override string RoleId { get; set; }
        public virtual ApplicationRole ApplicationRole { get; set; }
    }
}
