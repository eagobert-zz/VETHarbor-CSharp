using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VETHarbor.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using VETHarbor.Models.SearchViewModels;

namespace VETHarbor.Controllers
{
    public class SearchController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SearchController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(/*string programType, */string searchString)
        {
            //IQueryable<string> programQuery = from p in _context.Programs
            //                                  orderby p.ProgramType
            //                                  select p.ProgramType;

            var programs = from p in _context.Programs
                     select p;

            if (!String.IsNullOrEmpty(searchString))
            {
                programs = programs.Where(s => s.ProgramType.Contains(searchString));
            }

            //if (!String.IsNullOrEmpty(programType))
            //{
            //    programs = programs.Where(pt => pt.ProgramType == programType);
            //}

            //ProgramSearchViewModel model = new ProgramSearchViewModel();
            //model.programType = new SelectList(await programQuery.Distinct().ToListAsync());
           // model.programs = await programs.ToListAsync();

            return View(await programs.ToListAsync());
        }
    }
}