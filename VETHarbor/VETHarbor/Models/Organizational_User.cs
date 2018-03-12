using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VETHarbor.Models
{
    public class Organizational_User
    {
        public int OrgUserId { get; set; }

        public int OrganizationId { get; set; }
        public Organization Organization { get; set; }

        public int UserId { get; set; }
        public User_Profile User_Profile { get; set; }


    }
}
