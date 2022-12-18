

using AutoMapper;
using VayCayPlannerWeb.Contracts;

namespace VayCayPlannerWeb.Data.Repositories
{
    public class TravelerGroupsRepository : ITravelerGroupsRepository
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public TravelerGroupsRepository(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }



    }
}
