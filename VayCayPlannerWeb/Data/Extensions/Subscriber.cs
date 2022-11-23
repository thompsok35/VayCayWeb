using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace VayCayPlannerWeb.Data.Extensions
{
    public class Subscriber : IdentityUser
    {
        [MaxLength(256)]
        public string? FirstName { get; set; }
        [MaxLength(256)]
        public string? LastName { get; set; }
        [MaxLength(256)]
        public string? StreetAddress { get; set; }
        [MaxLength(256)]
        public string? City { get; set; }
        [MaxLength(256)]
        public string? State { get; set; }
        [MaxLength(256)]
        public string? ZipCode { get; set; }
        [MaxLength(256)]
        public string? Country { get; set; }

        [MaxLength(128)]
        public string? Mobile_Number { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime DateJoined { get; set; }
        public bool isActive { get; set; }
        public bool isTraveler { get; set; }
    }
}
