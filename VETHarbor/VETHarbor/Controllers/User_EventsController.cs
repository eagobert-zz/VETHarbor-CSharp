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
    public class User_EventsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public User_EventsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: User_Events
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.User_Events.Include(u => u.Events);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: User_Events/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user_Events = await _context.User_Events
                .Include(u => u.Events)
                .SingleOrDefaultAsync(m => m.UserEventId == id);
            if (user_Events == null)
            {
                return NotFound();
            }

            return View(user_Events);
        }

        // GET: User_Events/Create
        public IActionResult Create()
        {
            ViewData["EventId"] = new SelectList(_context.Events, "EventId", "EventId");
            return View();
        }

        // POST: User_Events/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserEventId,UserId,EventId")] User_Events user_Events)
        {
            if (ModelState.IsValid)
            {
                _context.Add(user_Events);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EventId"] = new SelectList(_context.Events, "EventId", "EventId", user_Events.EventId);
            return View(user_Events);
        }

        // GET: User_Events/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user_Events = await _context.User_Events.SingleOrDefaultAsync(m => m.UserEventId == id);
            if (user_Events == null)
            {
                return NotFound();
            }
            ViewData["EventId"] = new SelectList(_context.Events, "EventId", "EventId", user_Events.EventId);
            return View(user_Events);
        }

        // POST: User_Events/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UserEventId,UserId,EventId")] User_Events user_Events)
        {
            if (id != user_Events.UserEventId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(user_Events);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!User_EventsExists(user_Events.UserEventId))
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
            ViewData["EventId"] = new SelectList(_context.Events, "EventId", "EventId", user_Events.EventId);
            return View(user_Events);
        }

        // GET: User_Events/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user_Events = await _context.User_Events
                .Include(u => u.Events)
                .SingleOrDefaultAsync(m => m.UserEventId == id);
            if (user_Events == null)
            {
                return NotFound();
            }

            return View(user_Events);
        }

        // POST: User_Events/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var user_Events = await _context.User_Events.SingleOrDefaultAsync(m => m.UserEventId == id);
            _context.User_Events.Remove(user_Events);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool User_EventsExists(int id)
        {
            return _context.User_Events.Any(e => e.UserEventId == id);
        }
    }
}
