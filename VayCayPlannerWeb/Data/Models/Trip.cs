using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VayCayPlannerWeb.Data.Models
{
    public class Trip : BaseEntity
    {
        [MaxLength(128)]
        public string? Name { get; set; }
        [MaxLength(512)]
        public string? Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? Duration { get; set; }
        public int? DepartInDays { get; set; }
        public int? TotalTravelers { get; set; }
        public int? TotalDestinations { get; set; }

    }
}
