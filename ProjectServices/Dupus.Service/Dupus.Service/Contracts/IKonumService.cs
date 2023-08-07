using Models.Entities.Dupus.Entity.Dtos;
using Models.Entities.Dupus.Entity.Models;

namespace ProjectServices.Dupus.Services.Contracts
{
    public interface IKonumService
    {
        IEnumerable<UYKonum> GetAllKonumList(bool trackChanges);
        IEnumerable<UYKonum> GetAllKonumByKonumId(byte id, bool trackChanges);
        IEnumerable<GanttResourceGroupDto> GanttResourceGroup(byte id, bool trackChanges);        
    }
}
