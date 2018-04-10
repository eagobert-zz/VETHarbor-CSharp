using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VETHarbor.Models.AccountViewModels
{
    public class LoginViewModel
    {

        //[Required]
        //[Display(Name = "UserName")]
        //public string UserName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public Organization Organization { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }
}
