using AutoMapper;
using VayCayPlannerWeb.Data.Models;
using VayCayPlannerWeb.Models.ViewModels;

namespace VayCayPlannerWeb.Configuration
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Trip, Trip_vm>().ReverseMap();
            CreateMap<Traveler, Traveler_vm>().ReverseMap();

        }
    }
}
