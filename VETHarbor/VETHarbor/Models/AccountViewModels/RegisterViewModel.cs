using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VETHarbor.Models.AccountViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Choose a role")]
        public string Roles { get; set; }

        [Required]
        [Display(Name = "UserName")]
        public string UserName { get; set; }

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


        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        //[DataType(DataType.Password)]
        //[Display(Name = "Confirm password")]
        //[Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        //public string ConfirmPassword { get; set; }
    }
}
