using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VayCayPlannerWeb.Data.Extensions;

namespace VayCayPlannerWeb.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Subscriber>
    {
        public void Configure(EntityTypeBuilder<Subscriber> builder)
        {
            var hasher = new PasswordHasher<Subscriber>();
            builder.HasData(
                new Subscriber
                {
                    Id = "06946e45-c69a-4367-b611-aba9fecccbcb",
                    Email = "root@localhost.com",
                    NormalizedEmail = "ROOT@LOCALHOST.COM",
                    FirstName = "System",
                    LastName = "Root",
                    DateJoined = DateTime.Now,
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true
                }
            );
        }
    }
}
