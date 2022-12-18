using Microsoft.AspNetCore.SignalR;

namespace VayCayPlannerWeb.Data
{
    public abstract class OwnerEntity
    {
        public string UserId { get; set; } 
        public int TravelerId { get; set; }
        public int TravelGroupId { get; set; }
    }
}
