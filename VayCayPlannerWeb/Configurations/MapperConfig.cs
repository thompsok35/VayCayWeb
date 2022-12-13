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
            CreateMap<Destination, Destination_vm>().ReverseMap();
            CreateMap<Traveler, Traveler_vm>().ReverseMap();
            //CreateMap<Activity, Activity_vm>().ReverseMap();
            CreateMap<Package, Package_vm>().ReverseMap();
            //CreateMap<Transport, Transport_vm>().ReverseMap();
            CreateMap<Lodging, Lodging_vm>().ReverseMap();

        }
    }
}
