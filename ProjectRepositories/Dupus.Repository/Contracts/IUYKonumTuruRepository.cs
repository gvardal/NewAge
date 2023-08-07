using Models.Entities.Dupus.Entity.Models;

namespace ProjectRepositories.Dupus.Repository.Contracts
{
    public interface IUYKonumTuruRepository : IRepositoryBase<UYKonumTuru>
    {
        IQueryable<UYKonumTuru> GetAllKonumTuru(bool trackChanges);
    }
}
