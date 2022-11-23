using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VayCayPlannerWeb.Data.Models
{
    public class ActivityType : BaseEntity
    {
        [MaxLength(512)]
        public string? Name { get; set; }

        [MaxLength(512)]
        public string? Description { get; set; }

    }
}
