using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VETHarbor.Models
{
    public class Organizational_User
    {
        [Key]
        public int OrgUserId { get; set; }

        public int OrganizationId { get; set; }
        public Organization Organization { get; set; }

        public int UserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }


    }
}
