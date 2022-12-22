using VayCayPlannerWeb.Data.Models;
using VayCayPlannerWeb.Models.ViewModels;

namespace VayCayPlannerWeb.Contracts
{
    public interface IDestinationRepository : IGenericRepository<Destination>
    {
        List<Trip> GetTrips();
        //Task<List<Destination_vm>> GetAllAsync(int Id);
        Destination GetDestinationById(int Id);
        bool CreateDestination(Destination_vm viewModel);
        bool UpdateDestination(int Id, Destination_vm viewModel);
        bool AddDestination(TripDestinationCreateVM viewModel);
        IEnumerable<Destination_vm> GetDestinationsByTripId(int tripid);
        bool UpdateTripDestinationCount(int TripId);
        int CountDestinationsByTripId(int tripid);
        Destination GetTripDestination(int id);
        List<Destination_vm> GetDestinationsWithTripName();
    }
}
