using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OmegaAgenda.Data;
using OmegaAgenda.Models;

namespace OmegaAgenda.Controllers
{
    public class SchedulingsController : Controller
    {
        private readonly OmegaAgendaContext _context;

        public SchedulingsController(OmegaAgendaContext context)
        {
            _context = context;
        }

        // GET: Schedulings
        public async Task<IActionResult> Index()
        {
            return View(await _context.Scheduling.ToListAsync());
        }

        // GET: Schedulings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var scheduling = await _context.Scheduling
                .FirstOrDefaultAsync(m => m.Id == id);
            if (scheduling == null)
            {
                return NotFound();
            }

            return View(scheduling);
        }

        // GET: Schedulings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Schedulings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,StartTime,EndTime,Status")] Scheduling scheduling)
        {
            if (ModelState.IsValid)
            {
                _context.Add(scheduling);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(scheduling);
        }

        // GET: Schedulings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var scheduling = await _context.Scheduling.FindAsync(id);
            if (scheduling == null)
            {
                return NotFound();
            }
            return View(scheduling);
        }

        // POST: Schedulings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,StartTime,EndTime,Status")] Scheduling scheduling)
        {
            if (id != scheduling.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(scheduling);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SchedulingExists(scheduling.Id))
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
            return View(scheduling);
        }

        // GET: Schedulings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var scheduling = await _context.Scheduling
                .FirstOrDefaultAsync(m => m.Id == id);
            if (scheduling == null)
            {
                return NotFound();
            }

            return View(scheduling);
        }

        // POST: Schedulings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var scheduling = await _context.Scheduling.FindAsync(id);
            _context.Scheduling.Remove(scheduling);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SchedulingExists(int id)
        {
            return _context.Scheduling.Any(e => e.Id == id);
        }
    }
}
