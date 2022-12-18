using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using VayCayPlannerWeb.Contracts;
using VayCayPlannerWeb.Data.Extensions;

namespace VayCayPlannerWeb.Data.Repositories
{
    public class SubscriberRepository : ISubscriberRepository
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly UserManager<Subscriber> _userManager;

        public SubscriberRepository(ApplicationDbContext dbContext, IMapper mapper, UserManager<Subscriber> userManager)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _userManager = userManager;
        }

        public Subscriber GetProfileByEmail(string email)
        {
            var subscriber = _userManager.FindByEmailAsync(email);
            if (subscriber != null)
            {
                return subscriber.Result;
            }
            return null;
        }
    }
}
