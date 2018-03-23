using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using VETHarbor.Data;
using VETHarbor.Models;
using VETHarbor.ViewComponents;

namespace VETHarbor.ViewComponents
{
    public class OrganizationViewModel: Organization
    {
     
    }
}
[ViewComponent(Name = "Organization")]
public class OrganizationViewComponent : ViewComponent 
{
    private readonly ApplicationDbContext _context;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;

    public OrganizationViewComponent(ApplicationDbContext context, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
    {
        _context = context;
        _userManager = userManager;
        _signInManager = signInManager;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        // Get the current, authenticated user

        ApplicationUser user = await _userManager.GetUserAsync(HttpContext.User);


        OrganizationViewModel model = new OrganizationViewModel();

        //Determine if there is an organization assigned
        var organization = _context.Organizations;

        return View(model);
       
    }
}