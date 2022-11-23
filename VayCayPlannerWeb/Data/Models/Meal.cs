using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VayCayPlannerWeb.Data.Models
{
    public class Meal : BaseEntity
    {
        [MaxLength(512)]
        public string? Name { get; set; }
        public decimal PerPersonAverageCost { get; set; }

        // Table relationships
        [ForeignKey("MealTypeId")]
        public MealType? MealType { get; set; }
        public int MealTypeId { get; set; }
    }
}
