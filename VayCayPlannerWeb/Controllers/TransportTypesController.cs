using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VayCayPlannerWeb.Data;
using VayCayPlannerWeb.Data.Models;

namespace VayCayPlannerWeb.Controllers
{
    public class TransportTypesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TransportTypesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: TransportTypes
        public async Task<IActionResult> Index()
        {
              return View(await _context.TransportTypes.ToListAsync());
        }

        // GET: TransportTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TransportTypes == null)
            {
                return NotFound();
            }

            var transportType = await _context.TransportTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (transportType == null)
            {
                return NotFound();
            }

            return View(transportType);
        }

        // GET: TransportTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TransportTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Id,CreatedDate,ModifiedDate")] TransportType transportType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(transportType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(transportType);
        }

        // GET: TransportTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TransportTypes == null)
            {
                return NotFound();
            }

            var transportType = await _context.TransportTypes.FindAsync(id);
            if (transportType == null)
            {
                return NotFound();
            }
            return View(transportType);
        }

        // POST: TransportTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Name,Id,CreatedDate,ModifiedDate")] TransportType transportType)
        {
            if (id != transportType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(transportType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TransportTypeExists(transportType.Id))
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
            return View(transportType);
        }

        // GET: TransportTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TransportTypes == null)
            {
                return NotFound();
            }

            var transportType = await _context.TransportTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (transportType == null)
            {
                return NotFound();
            }

            return View(transportType);
        }

        // POST: TransportTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TransportTypes == null)
            {
                return Problem("Entity set 'ApplicationDbContext.TransportTypes'  is null.");
            }
            var transportType = await _context.TransportTypes.FindAsync(id);
            if (transportType != null)
            {
                _context.TransportTypes.Remove(transportType);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TransportTypeExists(int id)
        {
          return _context.TransportTypes.Any(e => e.Id == id);
        }
    }
}
