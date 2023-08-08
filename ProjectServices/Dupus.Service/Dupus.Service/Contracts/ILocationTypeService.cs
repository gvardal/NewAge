using Models.Entities.Dupus.Entity.Models;

namespace ProjectServices.Dupus.Services.Contracts
{
    public interface ILocationTypeService
    {
        IEnumerable<UYKonumTuru> GetAllLocationsType(bool trackChanges);
        UYKonumTuru? GetLocationTypeById(int id, bool trackChanges);

    }
}
