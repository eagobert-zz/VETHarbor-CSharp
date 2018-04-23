using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VETHarbor.Models
{
    public class Events
    {
        [Key]
        public int EventId { get; set; }

        public string OrgId { get; set; }
        public string OrgName { get; set; }
        public Organization Organization { get; set; }

        public string ProgramTitle { get; set; }
        public Programs Programs { get; set; }

        public string EventTitle { get; set; }

        public string EventDescription { get; set; }

        public DateTime EventStart { get; set; }

        public DateTime EventEnd { get; set; }

        public string EventPhotoUrl { get; set; }

    }
}
