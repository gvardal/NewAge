using Dupus.Repository.Contracts.IRepositoryManagers;
using Models.Entities.Dupus.Entity.Models;
using ProjectServices.Dupus.Services.Contracts;

namespace Dupus.Service.Services
{
    public class ProductsService : IProductsService
    {

        #region Members

        private readonly IRepositoryManager _repositoryManager;

        #endregion

        #region Constructor

        public ProductsService(IRepositoryManager manager)
        {
            _repositoryManager = manager;
        }

        #endregion

        #region Methods

        public UYUrunler? GetProductById(int id, bool trackChanges) => _repositoryManager.ProductsRepository.GetProductById(id, trackChanges);

        public IEnumerable<UYUrunler> GetAllProducts(bool trackChanges) => _repositoryManager.ProductsRepository.GetAllProducts(trackChanges);

        #endregion
    }
}
