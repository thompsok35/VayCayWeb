using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VayCayPlannerWeb.Data.Models
{
    public class TravelerGroups : BaseEntity
    {
        [MaxLength(450)]
        //[ForeignKey("UserId")]
        public string UserId { get; set; }

        //[ForeignKey("TravelerId")]
        //public Traveler? Traveler { get; set; }
        public int TravelerId { get; set;}

        [ForeignKey("TravelGroupId")]
        public TravelGroup? TravelGroup { get; set; }
        public int TravelGroupId { get; set; }
    }
}
