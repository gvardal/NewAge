using Dupus.Repository.Contracts.IRepositoryBases;
using Models.Entities.Dupus.Entity.Models;

namespace Dupus.Repository.Contracts.IRepositories
{
    public interface ILocationTypeRepository : IRepositoryBase<UYKonumTuru>
    {
        IQueryable<UYKonumTuru> GetAllLocationsType(bool trackChanges);
        IQueryable<UYKonumTuru> GetLocationTypeById(int id, bool trackChanges);

    }
}
