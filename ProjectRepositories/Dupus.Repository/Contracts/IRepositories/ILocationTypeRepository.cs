using Dupus.Entity.Models.ProductionManagment;
using Dupus.Repository.Contracts.IRepositoryBases;

namespace Dupus.Repository.Contracts.IRepositories
{
    public interface ILocationTypeRepository : IRepositoryBase<LocationsType>
    {
        IQueryable<LocationsType> GetAllLocationsType(bool trackChanges);
        IQueryable<LocationsType> GetLocationTypeById(int id, bool trackChanges);

    }
}
