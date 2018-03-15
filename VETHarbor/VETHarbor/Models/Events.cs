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

        public int OrgUserId { get; set; }
        public Organizational_User Organizational_User { get; set; }

        public string EventTitle { get; set; }

        public string EventDescription { get; set; }

        public DateTime EventStart { get; set; }

        public DateTime EventEnd { get; set; }

    }
}
