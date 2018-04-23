using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VETHarbor.Data;
using VETHarbor.Models;

namespace VETHarbor.Controllers
{
    public class ProgramsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProgramsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Programs
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Programs.Include(p => p.Organization);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Programs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var programs = await _context.Programs
                .Include(p => p.Organization)
                .SingleOrDefaultAsync(m => m.ProgramId == id);
            if (programs == null)
            {
                return NotFound();
            }

            return View(programs);
        }

        // GET: Programs/Create
        public IActionResult Create()
        {
            ViewData["OrgId"] = new SelectList(_context.Organizations, "OrgId", "OrgId");
            return View();
        }

        // POST: Programs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProgramId,OrgId,OrgName,ProgramType,ProgramTitle,ProgramCity,ProgramState,ProgramDescription,WebsiteUrl,ProgramPhotoUrl")] Programs programs)
        {
            if (ModelState.IsValid)
            {
                _context.Add(programs);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["OrgId"] = new SelectList(_context.Organizations, "OrgId", "OrgId", programs.OrgId);
            return View(programs);
        }

        // GET: Programs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var programs = await _context.Programs.SingleOrDefaultAsync(m => m.ProgramId == id);
            if (programs == null)
            {
                return NotFound();
            }
            ViewData["OrgId"] = new SelectList(_context.Organizations, "OrgId", "OrgId", programs.OrgId);
            return View(programs);
        }

        // POST: Programs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProgramId,OrgId,OrgName,ProgramType,ProgramTitle,ProgramCity,ProgramState,ProgramDescription,WebsiteUrl,ProgramPhotoUrl")] Programs programs)
        {
            if (id != programs.ProgramId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(programs);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProgramsExists(programs.ProgramId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["OrgId"] = new SelectList(_context.Organizations, "OrgId", "OrgId", programs.OrgId);
            return View(programs);
        }

        // GET: Programs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var programs = await _context.Programs
                .Include(p => p.Organization)
                .SingleOrDefaultAsync(m => m.ProgramId == id);
            if (programs == null)
            {
                return NotFound();
            }

            return View(programs);
        }

        // POST: Programs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var programs = await _context.Programs.SingleOrDefaultAsync(m => m.ProgramId == id);
            _context.Programs.Remove(programs);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProgramsExists(int id)
        {
            return _context.Programs.Any(e => e.ProgramId == id);
        }
    }
}
