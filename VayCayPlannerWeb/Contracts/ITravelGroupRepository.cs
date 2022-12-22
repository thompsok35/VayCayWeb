using VayCayPlannerWeb.Data.Models;
using VayCayPlannerWeb.Models.ViewModels;

namespace VayCayPlannerWeb.Contracts
{
    public interface ITravelGroupRepository
    {
        Task<int> AddNewTravelGroup(TravelGroup travelGroup);
        Task<List<TravelGroup>> MyTravelGroups();
    }
}
