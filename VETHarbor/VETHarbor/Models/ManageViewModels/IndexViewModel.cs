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

        //User Role View Starts Here:

        [DataType(DataType.MultilineText)]
        [Display(Name = "Street Address")]
        public string UserAddress { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "City")]
        public string UserCity { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "State")]
        public string UserState { get; set; }

        [DataType(DataType.PostalCode)]
        [Display(Name = "Zip Code")]
        public string UserZip { get; set; }

        //Administrator Role View Starts Here:

        [DataType(DataType.Text)]
        [Display(Name = "Organization Name")]
        public string OrganizationName { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "City")]
        public string OrganizationCity { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "State")]
        public string OrganizationState { get; set; }

       // [DataType(DataType.PostalCode)]
       // [Display(Name = "Zip Code")]
       // public string OrganizationZip { get; set; }
    }
}
