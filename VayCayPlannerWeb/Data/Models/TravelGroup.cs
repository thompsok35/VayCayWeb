using VayCayPlannerWeb.Data.Extensions;

namespace VayCayPlannerWeb.Data.Models
{
    public class TravelGroup : BaseEntity
    {
        //public int Id { get; set; }

        public string? GroupName { get; set; }

        public string? GroupDescription { get; set; }
        
    }
}
