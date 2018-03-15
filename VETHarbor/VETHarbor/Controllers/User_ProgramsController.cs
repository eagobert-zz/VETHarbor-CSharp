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
    public class User_ProgramsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public User_ProgramsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: User_Programs
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.User_Programs.Include(u => u.Programs);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: User_Programs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user_Programs = await _context.User_Programs
                .Include(u => u.Programs)
                .SingleOrDefaultAsync(m => m.UserProgId == id);
            if (user_Programs == null)
            {
                return NotFound();
            }

            return View(user_Programs);
        }

        // GET: User_Programs/Create
        public IActionResult Create()
        {
            ViewData["ProgramId"] = new SelectList(_context.Programs, "ProgramId", "ProgramId");
            return View();
        }

        // POST: User_Programs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserProgId,UserId,ProgramId")] User_Programs user_Programs)
        {
            if (ModelState.IsValid)
            {
                _context.Add(user_Programs);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProgramId"] = new SelectList(_context.Programs, "ProgramId", "ProgramId", user_Programs.ProgramId);
            return View(user_Programs);
        }

        // GET: User_Programs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user_Programs = await _context.User_Programs.SingleOrDefaultAsync(m => m.UserProgId == id);
            if (user_Programs == null)
            {
                return NotFound();
            }
            ViewData["ProgramId"] = new SelectList(_context.Programs, "ProgramId", "ProgramId", user_Programs.ProgramId);
            return View(user_Programs);
        }

        // POST: User_Programs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UserProgId,UserId,ProgramId")] User_Programs user_Programs)
        {
            if (id != user_Programs.UserProgId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(user_Programs);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!User_ProgramsExists(user_Programs.UserProgId))
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
            ViewData["ProgramId"] = new SelectList(_context.Programs, "ProgramId", "ProgramId", user_Programs.ProgramId);
            return View(user_Programs);
        }

        // GET: User_Programs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user_Programs = await _context.User_Programs
                .Include(u => u.Programs)
                .SingleOrDefaultAsync(m => m.UserProgId == id);
            if (user_Programs == null)
            {
                return NotFound();
            }

            return View(user_Programs);
        }

        // POST: User_Programs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var user_Programs = await _context.User_Programs.SingleOrDefaultAsync(m => m.UserProgId == id);
            _context.User_Programs.Remove(user_Programs);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool User_ProgramsExists(int id)
        {
            return _context.User_Programs.Any(e => e.UserProgId == id);
        }
    }
}
