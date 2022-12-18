using VayCayPlannerWeb.Data.Models;
using VayCayPlannerWeb.Models.ViewModels;

namespace VayCayPlannerWeb.Contracts
{
    public interface ITravelGroupRepository
    {
        int AddNewTravelGroup(TravelGroup travelGroup);
    }
}
