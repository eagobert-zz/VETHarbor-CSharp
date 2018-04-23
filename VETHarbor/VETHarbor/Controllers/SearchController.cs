using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VETHarbor.Data;

namespace VETHarbor.Controllers
{
    public class SearchController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SearchController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string searchString)
        {
            var programs = from p in _context.Programs
                     select p;

            if (!String.IsNullOrEmpty(searchString))
            {
                programs = programs.Where(s => );
            }

            return View(await programs.ToListAsync());
        }
    }
}