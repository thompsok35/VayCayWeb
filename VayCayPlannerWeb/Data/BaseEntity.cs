using System.ComponentModel.DataAnnotations;

namespace VayCayPlannerWeb.Data.Models
{
    public abstract class BaseEntity
    {
        // Default properties

        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

    }
}
