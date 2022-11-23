using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VayCayPlannerWeb.Data.Models;
using VayCayPlannerWeb.Data.Extensions;

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
        public DbSet<TripCostSummary> TripCostSummaries { get; set; }
        public DbSet<Subscriber> Subscribers { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<Traveler> Travelers { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<ActivityType> ActivityTypes { get; set; }
        public DbSet<Budget> Budgets { get; set; }
        public DbSet<BudgetType> BudgetTypes { get; set; }
        public DbSet<Lodging> Lodgings { get; set; }
        public DbSet<LodgingType> LodgingTypes { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<MealType> MealTypes { get; set; }
        public DbSet<Transport> Transports { get; set; }
        public DbSet<TransportType> TransportTypes { get; set; }

    
    }
}