using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VayCayPlannerWeb.Contracts;
using VayCayPlannerWeb.Data;
using VayCayPlannerWeb.Data.Extensions;
using VayCayPlannerWeb.Data.Models;
using VayCayPlannerWeb.Data.Repositories;
using VayCayPlannerWeb.Models.ViewModels;

namespace VayCayPlannerWeb.Controllers
{
    public class TripsController : Controller
    {
        private readonly ITripRepository _tripRepository;
        private readonly UserManager<Subscriber> _userManager;
        private readonly SignInManager<Subscriber> _signInManager;
        private readonly ISubscriberRepository _subscriberRepository;
        private readonly ITravelGroupRepository _travelGroupRepository;
        private readonly IMapper _mapper;

        public TripsController(ITripRepository tripRepository, 
                    UserManager<Subscriber> userManager, 
                    ISubscriberRepository subscriberRepository, 
                    SignInManager<Subscriber> signInManager,
                    ITravelGroupRepository travelGroupRepository, IMapper mapper)
        {
            _tripRepository = tripRepository;
            _userManager = userManager;
            _subscriberRepository = subscriberRepository;
            _mapper = mapper;
            _signInManager = signInManager;
            _travelGroupRepository = travelGroupRepository;
        }

        // GET: Trips
        public async Task<IActionResult> Index()
        {
            if (_signInManager.IsSignedIn(User))
            {
                var trips = _mapper.Map<List<Trip_vm>>(_tripRepository.Trips().Result);
                return View(trips);
            }
            return View();
        }

        // GET: Trips/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trip = await _tripRepository.GetAsync(id.Value);
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
            var model = new CreateTrip_vm
            {
                //You can pre-populate data into the fields of the view model here...
                //The SelectList provides the source data for drop doen
                TravelGroups = new SelectList(_travelGroupRepository.MyTravelGroups().Result, "Id", "GroupName")

            };

            return View(model);
        }

        // GET: Trips/CreateNewTrip
        public IActionResult CreateNewTrip()
        {
            return View();
        }

        // POST: Trips/CreateNewTrip
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Name,Description,StartDate,EndDate,Duration,DepartInDays,TotalTravelers,TotalDestinations,Id,CreatedDate,ModifiedDate")] Trip trip)
        public async Task<IActionResult> CreateFirstTrip(CreateFirstTrip_vm trip_vm)
        {
            if (trip_vm.Name != null)
            {
                var user = User.Identity?.Name;
                var organizer = _subscriberRepository.GetProfileByEmail(user);
                var newTrip = new CreateFirstTrip_vm
                {
                    Name = trip_vm.Name,
                    GroupName = trip_vm.GroupName,
                    SubscriberEmail = user,
                    SubscriberId = organizer.Id,
                };
                if (ModelState.IsValid)
                {
                    _tripRepository.CreateNewTrip(newTrip);
                    return RedirectToAction(nameof(Index));
                } 
            }
            return View(trip_vm);
        }

        // POST: Trips/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Name,Description,StartDate,EndDate,Duration,DepartInDays,TotalTravelers,TotalDestinations,Id,CreatedDate,ModifiedDate")] Trip trip)
        public async Task<IActionResult> Create(CreateTrip_vm trip_vm)
        {
            if (ModelState.IsValid)
            {
                //var trip = _mapper.Map<Trip>(trip_vm);
                await _tripRepository.CreateTrip(trip_vm);
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
            var trip = await _tripRepository.GetAsync(id.Value);
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
                    _tripRepository.UpdateTrip(id, trip_vm);
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
            var trip = await _tripRepository.GetAsync(id);
            if (trip != null)
            {
                await _tripRepository.DeleteAsync(id);
            }           

            return RedirectToAction(nameof(Index));
        }

        private async Task<bool> TripExists(int id)
        {
          return await _tripRepository.Exists(id);
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> CreateDestination(int Id)
        //{

        //}

    }
}
