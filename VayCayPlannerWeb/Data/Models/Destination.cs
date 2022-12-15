using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VayCayPlannerWeb.Data.Models
{
    public class Destination : BaseEntity
    {

        [MaxLength(256)]
        public string? CityName { get; set; }

        [MaxLength(256)]
        public string? CountryName { get; set; }

        public DateTime? ArrivalDate { get; set; }
        public DateTime? DepartureDate { get; set; }
        public int? Duration { get; set; }
        public bool isMealsIncluded { get; set; }
        public bool isActivityIncluded { get; set; }
        public int? PackageId { get; set; }

        // Table relationships
        [ForeignKey("TripId")]
        public Trip? Trip { get; set; }
        public int? TripId { get; set; }

    }
}
