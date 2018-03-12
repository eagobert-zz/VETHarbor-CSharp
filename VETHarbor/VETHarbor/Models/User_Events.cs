using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VETHarbor.Models
{
    public class User_Events
    {
        public int UserEventId { get; set; }

        public int UserId { get; set; }

        public int EventId { get; set; }
        public events Events { get; set; }
    }
}
