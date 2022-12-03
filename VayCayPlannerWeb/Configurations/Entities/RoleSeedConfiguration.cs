using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VayCayPlannerWeb.Configurations.Entities;
using VayCayPlannerWeb.Constants;

namespace VayCayPlannerWeb.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "06946e55-f70a-4267-b611-aba9fecccbcb",
                    Name = Roles.root,
                    NormalizedName = Roles.root.ToUpper()
                },
                new IdentityRole
                {
                    Id = "06946e55-f70d-4267-b611-aba9feccabcf",
                    Name = Roles.User,
                    NormalizedName = Roles.User.ToUpper()
                },
                new IdentityRole
                {
                    Id = "06946e55-f70b-4267-b611-aba9fecacbcb",
                    Name = Roles.TripManager,
                    NormalizedName = Roles.TripManager.ToUpper()
                },
                new IdentityRole
                {
                    Id = "06946e55-f70c-4267-b611-aba9fecacbcb",
                    Name = Roles.Traveler,
                    NormalizedName = Roles.Traveler.ToUpper()
                }
            );
        }
    }
}
