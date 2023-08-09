using Dupus.Entity.Models.ProductionManagment;
using Dupus.Repository.Contracts.IRepositoryBases;

namespace Dupus.Repository.Contracts.IRepositories
{
    public interface IProductsRepository : IRepositoryBase<Productions>
    {
        IQueryable<Productions> GetAllProducts(bool trackChanges);
        Productions? GetProductById(int id, bool trackChanges);
        string ProductName(int id, bool trackChanges);
    }
}
