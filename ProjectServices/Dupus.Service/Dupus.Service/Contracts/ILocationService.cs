using Dupus.Entity.Models.ProductionManagment;
using Models.Entities.Dupus.Entity.Dtos;

namespace ProjectServices.Dupus.Services.Contracts
{
    public interface ILocationService
    {
        IEnumerable<Locations> GetAllLocations(bool trackChanges);
        IEnumerable<Locations> GetLocationById(int id, bool trackChanges);
        IEnumerable<GanttResourceGroupDto> GanttResourceGroup(byte id, bool trackChanges);        
    }
}
