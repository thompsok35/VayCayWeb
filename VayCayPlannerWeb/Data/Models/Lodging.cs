using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VayCayPlannerWeb.Data.Models
{
    public class Lodging : BaseEntity
    {
        [MaxLength(512)]
        public string? Name { get; set; }
        public DateTime? CheckInDate { get; set; }
        public DateTime? CheckOutDate { get; set; }
        public int? MaxOccupancy { get; set; }
        public int Nights { get; set; }
        public decimal CleaningFees { get; set; }
        public decimal OtherFees { get; set; }
        public decimal TotalCost { get; set; }
        public string? WebLink { get; set; }

        //// Table relationships
        //[ForeignKey("LodgingTypeId")]
        //public LodgingType? LodgingType { get; set; }
        //public int LodgingTypeId { get; set; }

        //[ForeignKey("DestinationId")]
        //public Destination? Destination { get; set; }
        //public int DestinationId { get; set; }
    }
}
