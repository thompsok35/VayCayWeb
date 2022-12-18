using VayCayPlannerWeb.Data.Extensions;

namespace VayCayPlannerWeb.Contracts
{
    public interface ISubscriberRepository
    {
        Subscriber GetProfileByEmail(string email);
    }
}
