﻿using System.ComponentModel.DataAnnotations;
using VayCayPlannerWeb.Data.Models;

namespace VayCayPlannerWeb.Models.ViewModels
{
    public class Destination_vm
    {
        [Display(Name = "Trip Name")]
        public string? TripName { get; set; }
        public int TripId { get; set; }

        public List<Trip>? Trips { get; set; }

        [Display(Name = "City Name")]
        [Required]
        public string? CityName { get; set; }

        [Display(Name = "Country Name")]
        [Required]
        public string? CountryName { get; set; }

        public DateTime? ArrivalDate { get; set; }
        public DateTime? DepartureDate { get; set; }
        public int? Duration { get; set; }
        public int? PackageId { get; set; }
        public bool isMealsIncluded { get; set; }
        public bool isActivityIncluded { get; set; }
        public int Id { get; set; }

    }
}
