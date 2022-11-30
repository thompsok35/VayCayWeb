using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VayCayPlannerWeb.Contracts;
using VayCayPlannerWeb.Data;
using VayCayPlannerWeb.Data.Models;
using VayCayPlannerWeb.Data.Repositories;
using VayCayPlannerWeb.Models.ViewModels;

namespace VayCayPlannerWeb.Controllers
{
    public class TripsController : Controller
    {
        private readonly ITripRepository _context;
        private readonly IMapper _mapper;

        public TripsController(ITripRepository tripRepository, IMapper mapper)
        {
            _context = tripRepository;
            _mapper = mapper;
        }

        // GET: Trips
        public async Task<IActionResult> Index()
        {
            var trips = _mapper.Map<List<Trip_vm>>(await _context.GetAllAsync());
            return View(trips);
        }

        // GET: Trips/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trip = await _context.GetAsync(id.Value);
            if (trip == null)
            {
                return NotFound();
            }
            var trip_vm = _mapper.Map<Trip_vm>(trip);
            return View(trip_vm);
        }

        // GET: Trips/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Trips/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Name,Description,StartDate,EndDate,Duration,DepartInDays,TotalTravelers,TotalDestinations,Id,CreatedDate,ModifiedDate")] Trip trip)
        public async Task<IActionResult> Create(Trip_vm trip_vm)
        {
            if (ModelState.IsValid)
            {
                var trip = _mapper.Map<Trip>(trip_vm);
                await _context.AddAsync(trip);
                return RedirectToAction(nameof(Index));
            }
            return View(trip_vm);
        }

        // GET: Trips/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            //Get the record from the DB with the data model
            var trip = await _context.GetAsync(id.Value);
            if (trip == null)
            {
                return NotFound();
            }
            //Return the record with the View Model
            var trip_vm = _mapper.Map<Trip_vm>(trip);
            return View(trip_vm);
        }

        // POST: Trips/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Trip_vm trip_vm)
        {
            if (id != trip_vm.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var trip = _mapper.Map<Trip>(trip_vm);
                    await _context.UpdateAsync(trip);
                    //await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (! await TripExists(trip_vm.Id))
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
            return View(trip_vm);
        }

        // GET: Trips/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var trip = await _context.DeleteAsync(id.Value);
        //    if (trip == null)
        //    {
        //        return NotFound();
        //    }
        //    //Return the record with the View Model
        //    var trip_vm = _mapper.Map<Trip_vm>(trip);
        //    return View(trip_vm);
        //}

        // POST: Trips/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var trip = await _context.GetAsync(id);
            if (trip != null)
            {
                await _context.DeleteAsync(id);
            }           

            return RedirectToAction(nameof(Index));
        }

        private async Task<bool> TripExists(int id)
        {
          return await _context.Exists(id);
        }
    }
}
