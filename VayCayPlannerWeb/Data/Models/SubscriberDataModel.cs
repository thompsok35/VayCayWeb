using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using VayCayPlannerWeb.Data.Extensions;

namespace VayCayPlannerWeb.Data.Models
{
    public class SubscriberDataModel : Subscriber
    {
        public string TravelerRole { get; set; }
        public int RoleId { get; set; }
    }
}
