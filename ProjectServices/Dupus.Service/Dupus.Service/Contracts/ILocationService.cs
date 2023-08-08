using Models.Entities.Dupus.Entity.Dtos;
using Models.Entities.Dupus.Entity.Models;

namespace ProjectServices.Dupus.Services.Contracts
{
    public interface ILocationService
    {
        IEnumerable<UYKonum> GetAllLocations(bool trackChanges);
        IEnumerable<UYKonum> GetLocationById(byte id, bool trackChanges);
        IEnumerable<GanttResourceGroupDto> GanttResourceGroup(byte id, bool trackChanges);        
    }
}
