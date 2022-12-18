using VayCayPlannerWeb.Data.Models;
using VayCayPlannerWeb.Models.ViewModels;

namespace VayCayPlannerWeb.Contracts
{
    public interface ITripRepository : IGenericRepository<Trip>
    {
        IEnumerable<Trip> Trips();
        bool CreateNewTrip(CreateNewTrip_vm viewModel);
        Trip GetTripById(int Id);
        bool CreateTrip(Trip_vm trip_Vm);
        bool UpdateTrip(int tripId, Trip_vm viewModel);
        bool UpdateDestinationCount(int tripId);
    }
}
