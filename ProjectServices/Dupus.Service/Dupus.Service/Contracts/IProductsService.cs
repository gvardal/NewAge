using Dupus.Entity.Models.ProductionManagment;

namespace ProjectServices.Dupus.Services.Contracts
{
    public interface IProductsService
    {
        IEnumerable<Productions> GetAllProducts(bool trackChanges);
        Productions? GetProductById(int id, bool trackChanges);
    }
}
