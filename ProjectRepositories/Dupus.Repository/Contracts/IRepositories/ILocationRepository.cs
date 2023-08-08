using Dupus.Repository.Contracts.IRepositoryBases;
using Models.Entities.Dupus.Entity.Models;

namespace Dupus.Repository.Contracts.IRepositories
{
    public interface ILocationRepository : IRepositoryBase<UYKonum>
    {
        IQueryable<UYKonum> GetAllLocations(bool trackChanges);
        IQueryable<UYKonum> GetLocationById(byte id, bool trackChanges);
    }
}
