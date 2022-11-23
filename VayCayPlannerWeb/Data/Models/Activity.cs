using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace VayCayPlannerWeb.Data.Models
{
    public class Activity : BaseEntity
    {
        // Dataset Properties 
        [MaxLength(256)]
        public string? ActivityName { get; set; }
        [MaxLength(512)]
        public string? ActivityDescription { get; set; }
        public bool includesTransport { get; set; }
        public bool isPerPerson { get; set; }
        public decimal CostPerPerson { get; set; }
        public decimal TotalCost { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? Duration { get; set; }
        public string? WebLink { get; set; }

        //// Table relationships
        //[ForeignKey("ActivityTypeId")]
        //public ActivityType? ActivityType { get; set; }
        //public int ActivityTypeId { get; set; }

        //[ForeignKey("DestinationId")]
        //public Destination? Destination { get; set; }
        //public int DestinationId { get; set; }
    }
}
