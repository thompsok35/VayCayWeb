

using AutoMapper;
using Microsoft.EntityFrameworkCore;
using VayCayPlannerWeb.Contracts;
using VayCayPlannerWeb.Data.Models;

namespace VayCayPlannerWeb.Data.Repositories
{
    public class TravelGroupTripsRepository : ITravelGroupTripsRepository
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public TravelGroupTripsRepository(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public bool AddTripToGroup(TravelGroupTrips travelGroupTrips)
        {
            try
            {
                _dbContext.TravelGroupTrips.Add(travelGroupTrips);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
