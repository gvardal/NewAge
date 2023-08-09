using Dupus.Entity.Models.ProductionManagment;

namespace ProjectServices.Dupus.Services.Contracts
{
    public interface ILocationTypeService
    {
        IEnumerable<LocationsType> GetAllLocationsType(bool trackChanges);
        LocationsType? GetLocationTypeById(int id, bool trackChanges);

    }
}
