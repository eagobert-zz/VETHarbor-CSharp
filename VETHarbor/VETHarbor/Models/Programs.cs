using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VETHarbor.Models
{
    public class Programs
    {
        public int ProgramId { get; set; }

        public int OrgUserId { get; set; }
        public Organizational_User organizational_User { get; set; }

        public string ProgramTitle { get; set; }
        public string ProgramCity { get; set; }
        public string ProgramState { get; set; }
        public string ProgramDescription { get; set; }
        public string WebsiteUrl { get; set; }
        public string Phone { get; set; }
    }
}
