using System.ComponentModel.DataAnnotations;

namespace VayCayPlannerWeb.Data.Models
{
    public abstract class BaseEntity
    {
        // Default properties

        public int Id { get; set; }
        public string? UserId { get; set; }
        public int? TravelerId { get; set; }
        public int? PrimaryTravelGroupId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

    }
}
