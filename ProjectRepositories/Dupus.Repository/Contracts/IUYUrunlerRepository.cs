using Models.Entities.Dupus.Entity.Models;

namespace ProjectRepositories.Dupus.Repository.Contracts
{
    public interface IUYUrunlerRepository : IRepositoryBase<UYUrunler>
    {
        IQueryable<UYUrunler> GetAllUrunList(bool trackChanges);
        UYUrunler? GetUrunById(int id, bool trackChanges);
        string UrunAdi(int id, bool trackChanges);
    }
}
