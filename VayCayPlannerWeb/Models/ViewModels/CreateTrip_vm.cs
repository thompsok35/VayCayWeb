using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace VayCayPlannerWeb.Models.ViewModels
{
    public class CreateTrip_vm
    {
        public int Id { get; set; }

        [Display(Name = "Travel Group")]
        public int TravelGroupId { get; set; }
        //Source: TravelGroupRepository.MyTravelGroups()
        public SelectList? TravelGroups { get; set; }

        [Display(Name = "Trip Name")]
        [Required]
        public string? Name { get; set; }
        public string? Description { get; set; }

        [Display(Name = "Start Date")]
        [Required]
        public DateTime StartDate { get; set; }

        [Display(Name = "End Date")]
        [Required]
        public DateTime? EndDate { get; set; }

        //[Display(Name= "Trip Days")]
        //public int? Duration { get; set; }

        //[Display(Name = "Days To Departure")]
        //public int? DepartInDays { get; set; }

        //[Display(Name = "Total Travelers")]
        //public int? TotalTravelers { get; set; }

        //[Display(Name = "Total Destinations")]
        //public int? TotalDestinations { get; set; }

    }
}
