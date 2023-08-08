using Models.Entities.Dupus.Entity.Models;
using Dupus.Repository.EFCore.RepositoryBases;
using Dupus.Repository.EFCore.RepositoryContexts;
using Dupus.Repository.Contracts.IRepositories;

namespace Dupus.Repository.EFCore.Repositories
{
    public class ProductsRepository : RepositoryBase<UYUrunler>, IProductsRepository
    {

        #region Constructor

        public ProductsRepository(RepositoryContext context) : base(context)
        {
        }

        #endregion
        
        #region Methods

        public IQueryable<UYUrunler> GetAllProducts(bool trackChanges) => GetAll(trackChanges);

        public UYUrunler? GetProductById(int id, bool trackChanges) => GetByCondition(x => x.UrunID == id, trackChanges).FirstOrDefault();

        public string ProductName(int id, bool trackChanges)
        {
            return GetByCondition(x => x.UrunID == id, trackChanges).First().Adi!;
        }

        #endregion
    }
}
