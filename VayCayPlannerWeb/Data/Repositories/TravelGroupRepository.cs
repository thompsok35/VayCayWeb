using Microsoft.EntityFrameworkCore;
using VayCayPlannerWeb.Contracts;
using VayCayPlannerWeb.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using VayCayPlannerWeb.Models.ViewModels;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using VayCayPlannerWeb.Data.Extensions;

namespace VayCayPlannerWeb.Data.Repositories
{
    public class TravelGroupRepository : ITravelGroupRepository
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<Subscriber> _userManager;
        private readonly IMapper _mapper;

        public TravelGroupRepository(ApplicationDbContext dbContext,
            IHttpContextAccessor httpContextAccessor,
            UserManager<Subscriber> userManager, IMapper mapper) 
        {
            _dbContext = dbContext;
            //_tripRepository = tripRepository;
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task<int> AddNewTravelGroup(TravelGroup travelGroup)
        {
            int thisID = 0;
            var user = await CurrentUser();
            try
            {
                var thisTravelGroup = new TravelGroup 
                { 
                    GroupName = travelGroup.GroupName,
                    GroupDescription = travelGroup.GroupDescription,
                    UserId = user.Id,
                    TravelerId = user.TravelerId,
                    ModifiedDate = DateTime.Now,
                    CreatedDate = DateTime.Now                
                };

                _dbContext.Add(thisTravelGroup);
                _dbContext.SaveChanges();
                thisID = _dbContext.TravelGroups.Where(x => x.GroupName == travelGroup.GroupName).Select(y => y.Id).FirstOrDefault();
            }
            catch (Exception)
            {
                //log this error
                return thisID;
            }
            return thisID;
        }

        public async Task<List<TravelGroup>> MyTravelGroups()
        {            
            var user = await CurrentUser();
            try
            {
                var myGroups = await _dbContext.TravelGroups.Where(x => x.UserId == user.Id).ToListAsync();
                return myGroups;
            }
            catch (Exception)
            {
                //log this error
                return null;
            }            
        }

        private async Task<Subscriber> CurrentUser()
        {
            var user = await _userManager.GetUserAsync(_httpContextAccessor?.HttpContext?.User);
            if (user != null)
            {
                return user;
            }
            return null;
        }

    }
}
