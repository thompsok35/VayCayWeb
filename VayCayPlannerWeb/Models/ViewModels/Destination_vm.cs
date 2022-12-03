using System.ComponentModel.DataAnnotations;

namespace VayCayPlannerWeb.Models.ViewModels
{
    public class Destination_vm
    {
        public Trip_vm Name { get; set; }
        public int TripId { get; set; }

        [MaxLength(256)]
        public string? CityName { get; set; }

        [MaxLength(256)]
        public string? CountryName { get; set; }

        public DateTime? ArrivalDate { get; set; }
        public DateTime? DepartureDate { get; set; }
        public int? Duration { get; set; }
        public int? PackageId { get; set; }
        public bool isMealsIncluded { get; set; }
        public bool isActivityIncluded { get; set; }

    }
}
