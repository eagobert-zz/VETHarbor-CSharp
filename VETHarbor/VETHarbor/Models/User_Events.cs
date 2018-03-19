using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VETHarbor.Models
{
    public class User_Events
    {
        [Key]
        public int UserEventId { get; set; }

        public int UserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        public int EventId { get; set; }
        public Events Events { get; set; }

        //Represents a collection of user saved events
        public ICollection<Events> Event { get; set; }
    }
}
