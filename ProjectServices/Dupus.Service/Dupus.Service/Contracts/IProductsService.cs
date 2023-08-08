using Models.Entities.Dupus.Entity.Models;

namespace ProjectServices.Dupus.Services.Contracts
{
    public interface IProductsService
    {
        IEnumerable<UYUrunler> GetAllProducts(bool trackChanges);
        UYUrunler? GetProductById(int id, bool trackChanges);
    }
}
