using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VETHarbor.Models
{
    public class User_Programs
    {
        [Key]
        public int UserProgId { get; set; }

        public int UserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        public int ProgramId { get; set; }
        public Programs Programs { get; set; }

        //Represents a collection of user saved programs
        public ICollection<Programs> Program { get; set; }
    }
}
