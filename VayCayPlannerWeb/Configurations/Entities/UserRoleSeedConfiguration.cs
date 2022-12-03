using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VayCayPlannerWeb.Configurations.Entities;

namespace VayCayPlannerWeb.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {            
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "06946e55-f70a-4267-b611-aba9fecccbcb",
                    UserId = "06946e55-c69a-4267-b611-aba9fecccbcb"
                }
                //builder.HasData(
                //new IdentityUserRole<string>
                //{
                //    RoleId = "06946e55-f70a-4267-b611-aba9feccabcf",
                //    UserId = "06946e55-c69a-4267-b611-aba9fecccbcb",
                //}
            );
        }
    }
}
