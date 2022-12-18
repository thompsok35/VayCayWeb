using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace VayCayPlannerWeb.Models.ViewModels
{
    public class TravelGroupVM
    {
        public int Id { get; set; }

        [Display(Name = "Travel Group")]
        public string? GroupName { get; set; }
    }
}
