using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VayCayPlannerWeb.Data.Models
{
    public class TripCostSummary
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "money")]
        public decimal LodgingTotal { get; set; }
        [Column(TypeName = "money")]
        public decimal ActivityTotal { get; set; }
        [Column(TypeName = "money")]
        public decimal TransportTotal { get; set; }
        [Column(TypeName = "money")]
        public decimal MealTotal { get; set; }
        [Column(TypeName = "money")]
        public decimal TripTotal { get; set; }
    }
}
