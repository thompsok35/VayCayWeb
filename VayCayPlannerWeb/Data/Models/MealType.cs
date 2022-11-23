using System.ComponentModel.DataAnnotations;

namespace VayCayPlannerWeb.Data.Models
{
    public class MealType : BaseEntity
    {
        [MaxLength(512)]
        public string? Name { get; set; }

    }
}
