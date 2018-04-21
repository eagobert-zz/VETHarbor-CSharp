using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VETHarbor.Models.ManageViewModels
{
    public class IndexViewModel

    {

        public string Username { get; set; }

        public bool IsEmailConfirmed { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }

        public string StatusMessage { get; set; }

        public string OrgName { get; set; }
        public string OrgCity { get; set; }
        public string OrgState { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
