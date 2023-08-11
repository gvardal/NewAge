using Dupus.Entity.Models.ProductionManagment;
using Models.Entities.Dupus.Entity.Dtos;
using AutoMapper;

namespace Dupus.API.Extensions
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Locations, GanttResourceGroupDto>();
            CreateMap<Locations, ResourceListDto>();
        }
    }
}
