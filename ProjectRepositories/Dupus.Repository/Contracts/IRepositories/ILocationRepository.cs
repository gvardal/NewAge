using Dupus.Entity.Models.ProductionManagment;
using Dupus.Repository.Contracts.IRepositoryBases;

namespace Dupus.Repository.Contracts.IRepositories
{
    public interface ILocationRepository : IRepositoryBase<Locations>
    {
        IQueryable<Locations> GetAllLocations(bool trackChanges);
        IQueryable<Locations> GetLocationById(int id, bool trackChanges);
        IQueryable<Locations> GetLocationByLocationTypeId(int id, bool trackChanges);
    }
}
