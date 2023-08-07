using Models.Entities.Dupus.Entity.Models;

namespace ProjectRepositories.Dupus.Repository.Contracts
{
    public interface IUYKonumRepository : IRepositoryBase<UYKonum>
    {
        IQueryable<UYKonum> GetAllKonumList(bool trackChanges);
        IQueryable<UYKonum> GetAllKonumByKonumId(byte id, bool trackChanges);
    }
}
