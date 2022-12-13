using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using VayCayPlannerWeb.Data.Models;

namespace VayCayPlannerWeb.Models.ViewModels
{
    public class Activity_vm
    {
        public string? ActivityName { get; set; }
        public string? ActivityDescription { get; set; }
        public bool includesTransport { get; set; }
        public bool isPerPerson { get; set; }
        public decimal CostPerPerson { get; set; }
        public decimal TotalCost { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? Duration { get; set; }
        public string? WebLink { get; set; }

        // Table relationships
        //public ActivityType? ActivityType { get; set; }
        //public int ActivityTypeId { get; set; }

        public Destination? Destination { get; set; }
        public int DestinationId { get; set; }

    }
}
