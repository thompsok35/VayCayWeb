using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VayCayPlannerWeb.Data.Models
{
    public class Traveler : BaseEntity
    {
        [MaxLength(256)]
        public string? FirstName { get; set; }
        [MaxLength(256)]
        public string? LastName { get; set; }
        [MaxLength(256)]
        public string? EmailAddress { get; set; }
        [MaxLength(128)]
        public string? Mobile_Number { get; set; }
        public bool isActive { get; set; }
        public int? PrimaryRoleId { get; set; }
        public int? PrimaryGroupId { get; set; }

        //// Table relationships
        //[ForeignKey("TripId")]
        //public Trip? Trip { get; set; }
        //public int TripId { get; set; }

    }
}
