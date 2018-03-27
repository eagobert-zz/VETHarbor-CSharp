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
    public class UserEventsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserEventsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: UserEvents
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.User_Events.Include(u => u.Events);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: UserEvents/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userEvents = await _context.User_Events
                .Include(u => u.Events)
                .SingleOrDefaultAsync(m => m.UserEventId == id);
            if (userEvents == null)
            {
                return NotFound();
            }

            return View(userEvents);
        }

        // GET: UserEvents/Create
        public IActionResult Create()
        {
            ViewData["EventId"] = new SelectList(_context.Events, "EventId", "EventId");
            return View();
        }

        // POST: UserEvents/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserEventId,Id,EventId")] UserEvents userEvents)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userEvents);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EventId"] = new SelectList(_context.Events, "EventId", "EventId", userEvents.EventId);
            return View(userEvents);
        }

        // GET: UserEvents/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userEvents = await _context.User_Events.SingleOrDefaultAsync(m => m.UserEventId == id);
            if (userEvents == null)
            {
                return NotFound();
            }
            ViewData["EventId"] = new SelectList(_context.Events, "EventId", "EventId", userEvents.EventId);
            return View(userEvents);
        }

        // POST: UserEvents/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UserEventId,Id,EventId")] UserEvents userEvents)
        {
            if (id != userEvents.UserEventId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userEvents);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserEventsExists(userEvents.UserEventId))
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
            ViewData["EventId"] = new SelectList(_context.Events, "EventId", "EventId", userEvents.EventId);
            return View(userEvents);
        }

        // GET: UserEvents/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userEvents = await _context.User_Events
                .Include(u => u.Events)
                .SingleOrDefaultAsync(m => m.UserEventId == id);
            if (userEvents == null)
            {
                return NotFound();
            }

            return View(userEvents);
        }

        // POST: UserEvents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userEvents = await _context.User_Events.SingleOrDefaultAsync(m => m.UserEventId == id);
            _context.User_Events.Remove(userEvents);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserEventsExists(int id)
        {
            return _context.User_Events.Any(e => e.UserEventId == id);
        }
    }
}
