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
    public class LodgingsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LodgingsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Lodgings
        public async Task<IActionResult> Index()
        {
              return View(await _context.Lodgings.ToListAsync());
        }

        // GET: Lodgings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Lodgings == null)
            {
                return NotFound();
            }

            var lodging = await _context.Lodgings
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lodging == null)
            {
                return NotFound();
            }

            return View(lodging);
        }

        // GET: Lodgings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Lodgings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,CheckInDate,CheckOutDate,MaxOccupancy,Nights,CleaningFees,OtherFees,TotalCost,WebLink,Id,CreatedDate,ModifiedDate")] Lodging lodging)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lodging);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lodging);
        }

        // GET: Lodgings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Lodgings == null)
            {
                return NotFound();
            }

            var lodging = await _context.Lodgings.FindAsync(id);
            if (lodging == null)
            {
                return NotFound();
            }
            return View(lodging);
        }

        // POST: Lodgings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Name,CheckInDate,CheckOutDate,MaxOccupancy,Nights,CleaningFees,OtherFees,TotalCost,WebLink,Id,CreatedDate,ModifiedDate")] Lodging lodging)
        {
            if (id != lodging.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lodging);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LodgingExists(lodging.Id))
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
            return View(lodging);
        }

        // GET: Lodgings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Lodgings == null)
            {
                return NotFound();
            }

            var lodging = await _context.Lodgings
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lodging == null)
            {
                return NotFound();
            }

            return View(lodging);
        }

        // POST: Lodgings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Lodgings == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Lodgings'  is null.");
            }
            var lodging = await _context.Lodgings.FindAsync(id);
            if (lodging != null)
            {
                _context.Lodgings.Remove(lodging);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LodgingExists(int id)
        {
          return _context.Lodgings.Any(e => e.Id == id);
        }
    }
}
