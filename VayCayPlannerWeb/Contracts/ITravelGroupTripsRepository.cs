using VayCayPlannerWeb.Data.Models;
using VayCayPlannerWeb.Data.Repositories;

namespace VayCayPlannerWeb.Contracts
{
    public interface ITravelGroupTripsRepository 
    {

        bool AddTripToGroup(TravelGroupTrips travelGroupTrips);
    }
}
