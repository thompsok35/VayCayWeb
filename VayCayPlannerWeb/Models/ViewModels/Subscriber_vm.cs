using System.ComponentModel.DataAnnotations;

namespace VayCayPlannerWeb.Models.ViewModels
{
    public class Subscriber_vm
    {
        public string? Id { get; set; }

        [Display(Name = "First Name")] 
        public string? FirstName { get; set; }
        
        [Display(Name = "Last Name")]
        public string? LastName { get; set; }

        public bool isActive { get; set; }

        public bool isTraveler { get; set; }

        public int? TravelerId { get; set; }

        [Display(Name = "Street Address")]
        public string? StreetAddress { get; set; }       
        
        public string? City { get; set; }
        
        public string? State { get; set; }
        
        public string? ZipCode { get; set; }
        
        public string? Country { get; set; }

        [Display(Name = "Mobile Number")]
        public string? Mobile_Number { get; set; }

        //public DateTime? DateOfBirth { get; set; }

        [Display(Name = "Date Joined")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime DateJoined { get; set; }
        


    }
}
