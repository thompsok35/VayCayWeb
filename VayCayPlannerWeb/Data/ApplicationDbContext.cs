using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VayCayPlannerWeb.Data.Models;
using VayCayPlannerWeb.Data.Extensions;
using VayCayPlannerWeb.Configurations.Entities;

namespace VayCayPlannerWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext<Subscriber>
    //TODO: this inherits from Identity as type Subscriber (the extended class we created)
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }

        //Pluralize here so the table names get created correctly in the database
        public DbSet<Trip> Trips { get; set; }
        public DbSet<Subscriber> Subscribers { get; set; }
        public DbSet<Lodging> Lodgings { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<Traveler> Travelers { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<TravelGroupTrips> TravelGroupTrips { get; set; }
        public DbSet<TravelerGroups> TravelerGroups { get; set; }
        public DbSet<TravelGroup> TravelGroups { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new RoleSeedConfiguration());
            builder.ApplyConfiguration(new UserSeedConfiguration());
            builder.ApplyConfiguration(new UserRoleSeedConfiguration());
        }
    }
}