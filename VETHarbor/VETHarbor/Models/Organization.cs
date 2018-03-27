using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VETHarbor.Models
{
    public class Organization
    {
        [Key]
        public int OrgId { get; set; }
        public string OrganizationName { get; set; }
        public string OrganizationCity { get; set; }
        public string OrganizationState { get; set; }

        public virtual ICollection<Events> Events { get; set; }
        public virtual ICollection<Programs> Programs { get; set; }
    }
}
