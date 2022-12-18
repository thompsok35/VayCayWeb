using Microsoft.EntityFrameworkCore;
using VayCayPlannerWeb.Contracts;
using VayCayPlannerWeb.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using VayCayPlannerWeb.Models.ViewModels;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using AutoMapper;

namespace VayCayPlannerWeb.Data.Repositories
{
    public class DestinationRepository : GenericRepository<Destination>, IDestinationRepository
    {
        private readonly ITripRepository _tripRepository;
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public DestinationRepository(ApplicationDbContext dbContext,
                        ITripRepository tripRepository,
                        IMapper mapper) : base(dbContext)
        {
            _dbContext = dbContext;
            _tripRepository = tripRepository;
            _mapper = mapper;
        }

        public Destination GetTripDestination(int id)
        {
            var destination = _dbContext.Destinations
                .Include(x => x.Trip)
                .Where(d => d.Id == id).FirstOrDefault();
            if (destination != null)
            {
                return destination;
            }
            //var trip = _tripRepository.GetTripById(destinations.TripId);
            //var tripDestinations = _mapper.Map<List<DestinationBasicDetail_vm>>(List<Destination>);
            return destination;
        }

        public List<Trip> GetTrips()
        {
            var result = _dbContext.Trips.ToList();
            return result;
        }

        public Destination GetDestinationById(int Id)
        {
            return _dbContext.Destinations.Where(x => x.Id == Id).FirstOrDefault();
        }

        public bool CreateDestination(Destination_vm viewModel)
        {
            bool result = false;
            var tripname = _dbContext.Trips.Where(x => x.Id == viewModel.TripId).FirstOrDefault();
            try
            {
                var NewDestination = new Destination
                {
                    TripId = viewModel.TripId,
                    
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Today,
                    CityName = viewModel.CityName,
                    CountryName = viewModel.CountryName,                    
                    ArrivalDate = viewModel.ArrivalDate,
                    DepartureDate = viewModel.DepartureDate,
                    Duration = (viewModel.DepartureDate - viewModel.ArrivalDate).Value.Days,
                    isMealsIncluded = viewModel.isMealsIncluded,
                    isActivityIncluded = viewModel.isActivityIncluded,
                    PackageId = viewModel.PackageId
                    //Name = viewModel.Name,
                    //TotalDestinations = viewModel.TotalDestinations,
                    //TotalTravelers = viewModel.TotalTravelers
                };
                _dbContext.Add(NewDestination);
                _dbContext.SaveChanges();
                result = true;
            }
            catch (Exception ex)
            {
                result = false;
            }
            return result;
        }

        public bool UpdateDestination(int Id, Destination_vm viewModel)
        {
            bool result = false;
            var thisDestination = _dbContext.Destinations.Where(x => x.Id == Id).FirstOrDefault();
            try
            {
                if (thisDestination != null)
                {
                    thisDestination.TripId = viewModel.TripId;
                    thisDestination.ModifiedDate = DateTime.Today;
                    thisDestination.CityName = viewModel.CityName;
                    thisDestination.CountryName = viewModel.CountryName;
                    thisDestination.ArrivalDate = viewModel.ArrivalDate;
                    thisDestination.DepartureDate = viewModel.DepartureDate;
                    thisDestination.Duration = (viewModel.DepartureDate - viewModel.ArrivalDate).Value.Days;
                    thisDestination.isMealsIncluded = viewModel.isMealsIncluded;
                    thisDestination.isActivityIncluded = viewModel.isActivityIncluded;
                    thisDestination.PackageId = viewModel.PackageId;   
                };
                _dbContext.SaveChanges();
                UpdateTripDestinationCount(viewModel.TripId);
                result = true;
            }
            catch (Exception ex)
            {
                result = false;
            }
            return result;
        }

        public bool AddDestination(TripDestinationCreateVM viewModel)
        {
            bool result = false;
            var tripname = _dbContext.Trips.Where(x => x.Id == viewModel.TripId).FirstOrDefault();
            try
            {
                var NewDestination = new Destination
                {
                    TripId = viewModel.TripId,

                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Today,
                    CityName = viewModel.CityName,
                    CountryName = viewModel.CountryName,
                    ArrivalDate = viewModel.ArrivalDate,
                    DepartureDate = viewModel.DepartureDate,
                    Duration = (viewModel.DepartureDate - viewModel.ArrivalDate).Value.Days,
                    isMealsIncluded = viewModel.isMealsIncluded,
                    isActivityIncluded = viewModel.isActivityIncluded,
                    PackageId = viewModel.PackageId
                    //Name = viewModel.Name,
                    //TotalDestinations = viewModel.TotalDestinations,
                    //TotalTravelers = viewModel.TotalTravelers
                };
                _dbContext.Add(NewDestination);
                _dbContext.SaveChanges();
                UpdateTripDestinationCount(viewModel.TripId);
                result = true;
            }
            catch (Exception ex)
            {
                result = false;
            }
            return result;
         }

        public IEnumerable<Destination_vm> GetDestinationsByTripId(int tripid)
        {
            List<Destination_vm> result = new List<Destination_vm>();
            var destinations = _dbContext.Destinations.Where(x => x.TripId == tripid).ToList();
            var trip = _dbContext.Trips.Where(x => x.Id == tripid).FirstOrDefault();
            foreach (var item in destinations)
            {                
                var vmModel = new Destination_vm
                {
                    ArrivalDate = item.ArrivalDate,
                    isActivityIncluded = item.isActivityIncluded,
                    CityName = item.CityName,
                    CountryName = item.CountryName,
                    DepartureDate = item.DepartureDate,
                    Duration = item.Duration,
                    Id = item.Id,
                    isMealsIncluded = item.isMealsIncluded,
                    PackageId = item.PackageId,
                    TripName = trip.Name != null ? trip.Name : "Missing",
                    TripId = trip.Id
                };
                result.Add(vmModel);
            }

            return result;
        }

        public bool UpdateTripDestinationCount(int TripId)
        {            
            return _tripRepository.UpdateDestinationCount(TripId);
        }

        public int CountDestinationsByTripId(int tripid)
        {
            var destinations = _dbContext.Destinations.Where(x => x.TripId == tripid).ToList();
            return destinations.Count;
        }

        public List<Destination_vm> GetDestinationsWithTripName()
        {
            List<Destination_vm> result = new List<Destination_vm>();
            var destinations = _dbContext.Destinations.ToList();
            foreach (var item in destinations)
            {
                var trip = _dbContext.Trips.Where(x => x.Id == item.TripId).FirstOrDefault();
                var vmModel = new Destination_vm
                {
                    ArrivalDate = item.ArrivalDate,
                    isActivityIncluded = item.isActivityIncluded,
                    CityName = item.CityName,
                    CountryName = item.CountryName,
                    DepartureDate = item.DepartureDate,
                    Duration = item.Duration,
                    Id = item.Id,
                    isMealsIncluded = item.isMealsIncluded,
                    PackageId = item.PackageId,
                    TripName = trip.Name != null ? trip.Name : "Missing",
                    TripId = trip.Id
                };
                result.Add(vmModel);
            }

            return result;
        }

    }
}
