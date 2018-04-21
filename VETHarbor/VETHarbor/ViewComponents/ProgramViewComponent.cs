using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using VETHarbor.Data;
using VETHarbor.Models;

namespace VETHarbor.ViewComponents
{
    public class ProgramViewModel
    {
        //Create program model

        public int OrgId { get; set; }
        public Organization Organization { get; set; }

        public string ProgramType { get; set; }
        public string ProgramTitle { get; set; }
        public string ProgramCity { get; set; }
        public string ProgramState { get; set; }
        public string ProgramDescription { get; set; }
        public string WebsiteUrl { get; set; }
        public string ProgramPhotoUrl { get; set; }
        public IEnumerable<Programs> Programs { get; set; } = new List<Programs>();
      
    }

    /*ViewComponent: Displaying the user's org programs on the AdminView page*/

    [ViewComponent(Name = "Program")]
    public class ProgramViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public ProgramViewComponent(ApplicationDbContext c, UserManager<ApplicationUser> userManager)
        {
            _context = c;
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            //Get the current user
            ApplicationUser user = await _userManager.GetUserAsync(HttpContext.User);

            //Instantiate View Model
            ProgramViewModel model = new ProgramViewModel();

            //Determine if the user has any programs listed
            var programs = _context.Programs.Include(p => p.Organization).ToListAsync();


            //Render template bound to Program View Model
            return View(model);
        }
    }
}
