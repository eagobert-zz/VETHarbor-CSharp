using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VETHarbor.Models
{
    public class Programs
    {
        [Key]
        public int ProgramId { get; set; }

        public int OrgId { get; set; }
        public Organization Organization { get; set; }

        public string ProgramType { get; set; }
        public string ProgramTitle { get; set; }
        public string ProgramCity { get; set; }
        public string ProgramState { get; set; }
        public string ProgramDescription { get; set; }
        public string WebsiteUrl { get; set; }
        public string ProgramPhotoUrl { get; set; }
    }
}
