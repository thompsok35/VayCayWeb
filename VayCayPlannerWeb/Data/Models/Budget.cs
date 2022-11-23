using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VayCayPlannerWeb.Data.Models
{
    public class Budget : BaseEntity
    {
        [MaxLength(128)]
        public string? Name { get; set; }

        [MaxLength(512)]
        public string? Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal MonthlySavingTarget { get; set; }
        public decimal ProjectedSavingTarget { get; set; }
        public bool isInProgress { get; set; }
        public bool isOnTarget { get; set; }
        public bool enableReminders { get; set; }

        // Table relationships
        [ForeignKey("BudgetTypeId")]
        public BudgetType? BudgetType { get; set; }
        public int BudgetTypeId { get; set; }

        //[ForeignKey("TravelerId")]
        //public Traveler? Traveler { get; set; }
        //public int TravelerId { get; set; }
    }
}
