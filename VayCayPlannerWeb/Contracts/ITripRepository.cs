using VayCayPlannerWeb.Data.Models;
using VayCayPlannerWeb.Models.ViewModels;

namespace VayCayPlannerWeb.Contracts
{
    public interface ITripRepository : IGenericRepository<Trip>
    {
        Task<List<Trip>> Trips();
        Task<List<Trip>> MyUpcomingTrips();
        Task<List<Trip>> MyTrips();
        Task<bool> CreateNewTrip(CreateFirstTrip_vm viewModel);
        Trip GetTripById(int Id);
        Task<bool> CreateTrip(CreateTrip_vm viewModel);
        bool UpdateTrip(int tripId, Trip_vm viewModel);
        bool UpdateDestinationCount(int tripId);
    }
}
