using Dupus.Repository.Contracts.IRepositoryBases;
using Models.Entities.Dupus.Entity.Models;

namespace Dupus.Repository.Contracts.IRepositories
{
    public interface IProductsRepository : IRepositoryBase<UYUrunler>
    {
        IQueryable<UYUrunler> GetAllProducts(bool trackChanges);
        UYUrunler? GetProductById(int id, bool trackChanges);
        string ProductName(int id, bool trackChanges);
    }
}
