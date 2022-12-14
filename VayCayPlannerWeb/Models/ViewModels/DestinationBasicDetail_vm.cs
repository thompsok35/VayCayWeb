using System.ComponentModel.DataAnnotations;
using VayCayPlannerWeb.Data.Models;

namespace VayCayPlannerWeb.Models.ViewModels
{
    public class DestinationBasicDetail_vm
    {
        public Trip? Trip { get; set; }

        [Display(Name = "DestinationId")]
        public int Id { get; set; }

        [Display(Name = "City Name")]
        public string? CityName { get; set; }

        [Display(Name = "Country Name")]
        public string? CountryName { get; set; }

        //public DateTime? ArrivalDate { get; set; }
        //public DateTime? DepartureDate { get; set; }
        //public int? Duration { get; set; }
        //public int? PackageId { get; set; }
        //public bool isMealsIncluded { get; set; }
        //public bool isActivityIncluded { get; set; }
        //public int Id { get; set; }

    }
}
