using Microsoft.AspNetCore.Identity;

namespace VayCayPlannerWeb.Data.Extensions
{
    public class RoleDescription : IdentityRole
    {
        public string Description { get; set; }
    }
}
