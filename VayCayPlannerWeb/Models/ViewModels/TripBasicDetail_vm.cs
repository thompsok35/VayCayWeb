using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace VayCayPlannerWeb.Models.ViewModels
{
    public class TripBasicDetail_vm
    {
        [Display(Name = "TripId")]
        public int Id { get; set; }

        [Display(Name = "Trip Name")]
        public string? Name { get; set; }
        
        [Display(Name = "Trip Description")]
        public string? Description { get; set; }               

        [Display(Name = "Days Until Departure")]
        public int? DepartInDays { get; set; }
    }
}
