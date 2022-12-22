using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace VayCayPlannerWeb.Models.ViewModels
{
    public class CreateFirstTrip_vm
    {

        //[Display(Name = "TripId")]
        public int TripId { get; set; }

        [Display(Name = "Name your Trip")]
        [Required]
        public string? Name { get; set; }

        [Display(Name = "Add Travel Group")]
        public int TravelGroupId { get; set; }
        //Source: TravelGroupRepository.MyTravelGroups()
        public SelectList? TravelGroups { get; set; }

        [Display(Name = "Name your Travel Group")]
        [Required]
        public string? GroupName { get; set; }
        
        public string? SubscriberId { get; set; }
        public string? SubscriberEmail { get; set; }

        public Subscriber_vm? SubscriberDetail{ get; set; }
    }
}
