using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VETHarbor.Models
{
    public class Organization
    {

        //public Organization()
        //{
        //   // OrgId = Guid.NewGuid().ToString();
        //    ApplicationUsers = new List<ApplicationUser>();
        //}

        //public Organization(string name)
        //    : this()
        //{
        //    OrgName = name;
        //}

        [Key]
        public string OrgId { get; set; }
        public string OrgName { get; set; }
        public string OrgCity { get; set; }
        public string OrgState { get; set; }

        public virtual ICollection<ApplicationUser> ApplicationUsers { get; set; }
        public virtual ICollection<Events> Events { get; set; }
        public virtual ICollection<Programs> Programs { get; set; }
    }
}