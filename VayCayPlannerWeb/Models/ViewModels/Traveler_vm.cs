using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VayCayPlannerWeb.Models.ViewModels
{
    public class Traveler_vm
    {
        public int Id { get; set; }

        [Display(Name = "First Name")]
        public string? FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string? LastName { get; set; }
        [Display(Name = "Email")]
        public string? EmailAddress { get; set; }
        [Display(Name = "Mobile Number")]
        public string? Mobile_Number { get; set; }
        [Display(Name = "Traveler Status")]
        public bool isActive { get; set; }

        //public int? PrimaryRoleId { get; set; }
        //public int? PrimaryGroupId { get; set; }

        //// Table relationships
        //[ForeignKey("TripId")]
        //public Trip? Trip { get; set; }
        //public int TripId { get; set; }

    }
}
