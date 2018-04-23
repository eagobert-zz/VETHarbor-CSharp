using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using VETHarbor.Data;
using VETHarbor.Models;

namespace VETHarbor.ViewComponents
{
    public class ProfileViewModel
    {
        //Create user profile layout
        public string OrgName { get; set; }
        public string OrgCity { get; set; }
        public string OrgState { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }

    /*ViewComponent: Displaying the user's org profile on the AdminView page*/

    [ViewComponent(Name = "Profile")]
    public class ProfileViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public ProfileViewComponent(ApplicationDbContext c, UserManager<ApplicationUser> userManager)
        {
            _context = c;
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            //Get the current user
            ApplicationUser user = await _userManager.GetUserAsync(HttpContext.User);

            //Instantiate View Model
            ProfileViewModel model = new ProfileViewModel
            {

                OrgName = user.OrgName,
                OrgCity = user.OrgCity,
                OrgState = user.OrgState,

            };

            //Check current user's profile info




            //Render template bound to Profile View Model
            return View(model);
        }
    }
}
