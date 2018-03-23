using Microsoft.AspNetCore.Mvc;
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
        public int OrganizationId { get; set; }
        public string OrganizationName { get; set; }
        public string OrganizationAddress { get; set; }
        public string OrganizationCity { get; set; }
        public string OrganizationState { get; set; }
        public string OrganizationZip { get; set; }
        public string ImageUrl { get; set; }
        public string OrgUrl { get; set; }
    }
}
