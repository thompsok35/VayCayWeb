using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using VayCayPlannerWeb.Data.Models;

namespace VayCayPlannerWeb.Models.ViewModels
{
    public class TripDestinationCreateVM 
    {
        public int Id { get; set; }
        public int TripId { get; set; }

        [Display(Name = "Trip Name")]
        public string? TripName { get; set; }

        //public List<Trip>? Trips { get; set; }

        //[Display(Name = "Trip Name")]
        //public string? Name { get; set; }

        [Display(Name = "City Name")]
        [Required]
        public string? CityName { get; set; }

        [Display(Name = "Country Name")]
        [Required]
        public string? CountryName { get; set; }

        public DateTime? ArrivalDate { get; set; }
        public DateTime? DepartureDate { get; set; }
        public bool isMealsIncluded { get; set; }
        public bool isActivityIncluded { get; set; }
        public int? PackageId { get; set; }
    }
}
