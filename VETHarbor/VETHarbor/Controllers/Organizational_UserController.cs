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
    public class Organizational_UserController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Organizational_UserController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Organizational_User
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Organizational_User.Include(o => o.Organization);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Organizational_User/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var organizational_User = await _context.Organizational_User
                .Include(o => o.Organization)
                .SingleOrDefaultAsync(m => m.OrgUserId == id);
            if (organizational_User == null)
            {
                return NotFound();
            }

            return View(organizational_User);
        }

        // GET: Organizational_User/Create
        public IActionResult Create()
        {
            ViewData["OrganizationId"] = new SelectList(_context.Organizations, "OrganizationId", "OrganizationId");
            return View();
        }

        // POST: Organizational_User/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrgUserId,OrganizationId,UserId")] Organizational_User organizational_User)
        {
            if (ModelState.IsValid)
            {
                _context.Add(organizational_User);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["OrganizationId"] = new SelectList(_context.Organizations, "OrganizationId", "OrganizationId", organizational_User.OrganizationId);
            return View(organizational_User);
        }

        // GET: Organizational_User/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var organizational_User = await _context.Organizational_User.SingleOrDefaultAsync(m => m.OrgUserId == id);
            if (organizational_User == null)
            {
                return NotFound();
            }
            ViewData["OrganizationId"] = new SelectList(_context.Organizations, "OrganizationId", "OrganizationId", organizational_User.OrganizationId);
            return View(organizational_User);
        }

        // POST: Organizational_User/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrgUserId,OrganizationId,UserId")] Organizational_User organizational_User)
        {
            if (id != organizational_User.OrgUserId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(organizational_User);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Organizational_UserExists(organizational_User.OrgUserId))
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
            ViewData["OrganizationId"] = new SelectList(_context.Organizations, "OrganizationId", "OrganizationId", organizational_User.OrganizationId);
            return View(organizational_User);
        }

        // GET: Organizational_User/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var organizational_User = await _context.Organizational_User
                .Include(o => o.Organization)
                .SingleOrDefaultAsync(m => m.OrgUserId == id);
            if (organizational_User == null)
            {
                return NotFound();
            }

            return View(organizational_User);
        }

        // POST: Organizational_User/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var organizational_User = await _context.Organizational_User.SingleOrDefaultAsync(m => m.OrgUserId == id);
            _context.Organizational_User.Remove(organizational_User);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Organizational_UserExists(int id)
        {
            return _context.Organizational_User.Any(e => e.OrgUserId == id);
        }
    }
}
