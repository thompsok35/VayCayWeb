using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using VayCayPlannerWeb.Contracts;
using VayCayPlannerWeb.Data.Models;
using VayCayPlannerWeb.Models.ViewModels;

namespace VayCayPlannerWeb.Data.Repositories
{
    public class TripRepository : GenericRepository<Trip>, ITripRepository
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly ITravelGroupRepository _travelGroupRepository;

        public TripRepository(ApplicationDbContext dbContext, ITravelGroupRepository travelGroupRepository) : base(dbContext)
        {
            _dbContext = dbContext;
            _travelGroupRepository =travelGroupRepository;
        }

        public IEnumerable<Trip> Trips()
        {
            var trips = _dbContext.Trips.ToList();
            return trips;
        }

        public Trip GetTripById(int Id)
        {
            var result = new Trip();
            var thisTrip = _dbContext.Trips.Where(x => x.Id == Id).FirstOrDefault();
            if (thisTrip != null)
            {
                return thisTrip;
            }
            return null;
        }

        public bool CreateTrip(Trip_vm viewModel)
        {
            bool result = false;

            try
            {
                var NewTrip = new Trip
                {
                    CreatedDate = DateTime.Now,
                    DepartInDays = ((int)(viewModel.StartDate - DateTime.Today).TotalDays),
                    Description = viewModel.Description,                    
                    Duration = (viewModel.EndDate - viewModel.StartDate).Value.Days,
                    StartDate = viewModel.StartDate,
                    EndDate = viewModel.EndDate,
                    ModifiedDate = DateTime.Today,
                    Name = viewModel.Name,
                    TotalDestinations = viewModel.TotalDestinations,
                    TotalTravelers = viewModel.TotalTravelers
                };
                _dbContext.Add(NewTrip);
                _dbContext.SaveChanges();
                result = true;
            }
            catch (Exception ex)
            {
                result = false;               
            }
            return result;
        }

        public bool CreateNewTrip(CreateNewTrip_vm viewModel)
        {
            bool result = false;

            try
            {
                var NewTrip = new Trip
                {
                    CreatedDate = DateTime.Now, 
                    ModifiedDate = DateTime.Today,
                    Name = viewModel.Name,
                };
                var NewTravelGroup = new TravelGroup
                {                    
                    GroupName = viewModel.GroupName,
                    GroupDescription = $"Travel group for the [{viewModel.Name}] trip",
                };
                _dbContext.Add(NewTrip);
                var thisTravelGroupId = _travelGroupRepository.AddNewTravelGroup(NewTravelGroup);
                _dbContext.SaveChanges();
                var thisTrip = _dbContext.Trips.Where(x => x.Name == viewModel.Name).FirstOrDefault();
                var thisTravelGroupTrip = new TravelGroupTrips
                {
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Today,
                    TravelGroupId = thisTravelGroupId,
                    TripId = thisTrip.Id
                };
                _dbContext.Add(thisTravelGroupTrip);
                _dbContext.SaveChanges();

                var NewTravelerGroup = new TravelerGroups 
                {
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Today,
                    TravelGroupId = 1,
                    UserId = viewModel.SubscriberId,
                    //TripId = viewModel.TripId,
                };
                _dbContext.Add(NewTravelerGroup);
                _dbContext.SaveChanges();
                //foreach (var traveler in viewModel.Travelers)
                //{
                //    var TravelGroupTrip = new TravelGroupTrips
                //    {
                //        CreatedDate = DateTime.Today,
                //        TripId = thisTrip.Id,
                //        TravelGroupId = 1,
                //        ModifiedDate = DateTime.Today,
                //    };
                //    _dbContext.Add(TravelGroupTrip);
                //};

                result = true;
            }
            catch (Exception ex)
            {
                result = false;
            }
            return result;
        }

        public int DestinationCount(int TripId)
        {
            var destinations = _dbContext.Destinations.Where(x => x.TripId == TripId).Count();
            return destinations;
        }

        public bool UpdateDestinationCount(int tripId)
        {
            bool result = false;
            var thisTrip = _dbContext.Trips.Where(x => x.Id == tripId).FirstOrDefault();
            var destinationCount = DestinationCount(tripId);
            try
            {
                if (thisTrip != null)
                {
                    thisTrip.TotalDestinations = DestinationCount(tripId);
                    _dbContext.SaveChanges();
                    result = true;
                }
                
            }
            catch (Exception)
            {
                //log the error
            }
            return result;
        }

        public bool UpdateTrip(int tripId, Trip_vm viewModel)
        {
            bool result = false;
            var thisTrip = _dbContext.Trips.Where(x => x.Id == viewModel.Id).FirstOrDefault();
            var destinationCount = DestinationCount(tripId);
            try
            {
                if (thisTrip != null)
                {
                    thisTrip.ModifiedDate = DateTime.Now;
                    thisTrip.Name = viewModel.Name;
                    thisTrip.Description = viewModel.Description;
                    thisTrip.TotalDestinations = DestinationCount(tripId);
                    thisTrip.Duration = (viewModel.EndDate - viewModel.StartDate).Value.Days;
                    thisTrip.DepartInDays = ((int)(viewModel.StartDate - DateTime.Today).TotalDays);
                    thisTrip.Description = viewModel.Description;
                    thisTrip.StartDate = viewModel.StartDate;
                    thisTrip.EndDate = viewModel.EndDate;
                }
                _dbContext.SaveChanges();
                result = true;
            }
            catch (Exception)
            {
                //log the error
            }
            return result;
        }
    }
}
