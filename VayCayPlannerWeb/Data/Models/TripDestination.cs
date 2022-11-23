using System.ComponentModel.DataAnnotations.Schema;

namespace VayCayPlannerWeb.Data.Models
{
    public class TripDestination : BaseEntity
    {
        // Table relationships
        [ForeignKey("TripId")]
        public Trip? Trip { get; set; }
        public int TripId { get; set; }

        [ForeignKey("DestinationId")]
        public Destination? Destination { get; set; }
        public int DestinationId { get; set; }
        
    }
}
