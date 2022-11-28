using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VayCayPlannerWeb.Data.Models
{
    public class Transport : BaseEntity
    {
        [MaxLength(512)]
        public string? Name { get; set; }
        public int? DepartureDestinationId { get; set; }
        public DateTime Departure { get; set; }       
        public DateTime Arrival { get; set; }
        public decimal TotalCost { get; set; }
        public int? Stops { get; set; }
        public bool isRoundTrip { get; set; }
        public bool isInsured { get; set; }
        public bool isPointsUsed { get; set; }

        // Table relationships
        [ForeignKey("TransportTypeId")]
        public TransportType? TransportType { get; set; }
        public int TransportTypeId { get; set; }
        //public TransportType? TransportName { get; set; }

        [ForeignKey("DestinationId")]        
        public int DestinationId { get; set; }
        public Destination? ArrivalDestination { get; set; }
        //public Destination? ArrivalDestinationCityName { get; set; }


    }
}
