using VayCayPlannerWeb.Contracts;
using VayCayPlannerWeb.Data.Models;

namespace VayCayPlannerWeb.Data.Repositories
{
    public class TripRepository : GenericRepository<Trip>, ITripRepository
    {
        public TripRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
    }
}
