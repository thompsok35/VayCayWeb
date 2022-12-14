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
    public class DestinationsController : Controller
    {
        private readonly IDestinationRepository _destination;
        private readonly ITripRepository _trip;
        private readonly IMapper _mapper;

        public DestinationsController(IDestinationRepository destinationRepository,
            ITripRepository tripRepository, IMapper mapper)
        {
            _destination = destinationRepository;
            _trip = tripRepository;
            _mapper = mapper;
        }

        // GET: Destinations
        public async Task<IActionResult> Index()
        {
            var destinations = _destination.GetDestinationsWithTripName();            
            return View(destinations);
        }

        //// GET: Destinations/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        // GET: Destinations/TripDestinations
        public async Task<IActionResult> TripDestinations(int Id)
        {
            var destinations = _destination.GetDestinationsByTripId(Id);
            ViewData["Trip"] = _trip.GetTripById(Id);
            return View(destinations);
        }

        // GET: Destinations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var destination = _mapper.Map<Destination_vm>(_destination.GetDestinationById(id.Value));
            
            if (destination == null)
            {
                return NotFound();
            }

            return View(destination);
        }

        // GET: Destinations/Create
        public IActionResult Create(int? id)
        {
            ViewData["Trips"] = new SelectList(_destination.GetTrips(), "Id", "Name", _destination.GetTrips());
            //List<Trip> trips = _destination.GetTrips();
            return View();
        }

        // POST: Destinations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Destination_vm destination_vm)
        {
            if (ModelState.IsValid)
            {
                _destination.CreateDestination(destination_vm);
                return RedirectToAction(nameof(Index));
            }
            //ViewData["TripName"] = new SelectList(_trip.Trips(), "Id", "Name");
            return View(destination_vm);
        }


        // GET: Destinations/AddTrip
        public async Task<IActionResult> PopulateTrip(TripDestinationCreateVM newDestination)
        {
            var thisTrip = await _trip.GetAsync(newDestination.Id);
            newDestination.TripName = thisTrip.Name;
            newDestination.TripId = thisTrip.Id;
            return View(newDestination);
        }

        // POST: Destinations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddToTrip(TripDestinationCreateVM newDestination)
        {
            var tripId = newDestination.TripId;
            if (ModelState.IsValid)
            {
                _destination.AddDestination(newDestination);
                
                return RedirectToAction("TripDestinations",new { Id = tripId });
            }
            //ViewData["TripName"] = new SelectList(_trip.Trips(), "Id", "Name");
            return View(newDestination);
        }

        // GET: Destinations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var destination = await _destination.GetAsync(id.Value);
            if (destination == null)
            {
                return NotFound();
            }
            //ViewData["TripId"] = new SelectList(_context.Trips, "Id", "Id", destination.TripId);
            var destination_vm = _mapper.Map<Destination_vm>(destination);
            return View(destination_vm);
        }

        // POST: Destinations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Destination_vm destination_vm)
        {
            var tripId = destination_vm.TripId;
            if (id != destination_vm.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {                    
                    _destination.UpdateDestination(id, destination_vm);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (! await _destination.Exists(destination_vm.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("TripDestinations", new { Id = tripId });
            }
            //ViewData["TripId"] = new SelectList(_context.Trips, "Id", "Id", destination.TripId);
            return View(destination_vm);
        }

        //// GET: Destinations/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null || _context.Destinations == null)
        //    {
        //        return NotFound();
        //    }

        //    var destination = await _context.Destinations
        //        .Include(d => d.Trip)
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (destination == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(destination);
        //}

        // POST: Destinations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {

            var destination = await _destination.GetAsync(id);
            if (destination != null)
            {
                await _destination.DeleteAsync(id);
            }            
            return RedirectToAction(nameof(Index));
        }

        //private bool DestinationExists(int id)
        //{
        //  return _context.Destinations.Any(e => e.Id == id);
        //}
    }
}
