using Microsoft.EntityFrameworkCore;
using VayCayPlannerWeb.Contracts;
using VayCayPlannerWeb.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using VayCayPlannerWeb.Models.ViewModels;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using AutoMapper;


namespace VayCayPlannerWeb.Data.Repositories
{
    public class TravelGroupRepository : ITravelGroupRepository
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public TravelGroupRepository(ApplicationDbContext dbContext, IMapper mapper) 
        {
            _dbContext = dbContext;
            //_tripRepository = tripRepository;
            _mapper = mapper;
        }

        public int AddNewTravelGroup(TravelGroup travelGroup)
        {
            int thisID = 0;
            try
            {
                _dbContext.Add(travelGroup);
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

    }
}
