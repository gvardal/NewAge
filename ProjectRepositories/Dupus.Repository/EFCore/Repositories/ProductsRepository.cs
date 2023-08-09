using Dupus.Repository.EFCore.RepositoryBases;
using Dupus.Repository.EFCore.RepositoryContexts;
using Dupus.Repository.Contracts.IRepositories;
using Dupus.Entity.Models.ProductionManagment;

namespace Dupus.Repository.EFCore.Repositories
{
    public class ProductsRepository : RepositoryBase<Productions>, IProductsRepository
    {

        #region Constructor

        public ProductsRepository(RepositoryContext context) : base(context)
        {
        }

        #endregion
        
        #region Methods

        public IQueryable<Productions> GetAllProducts(bool trackChanges) => GetAll(trackChanges);

        public Productions? GetProductById(int id, bool trackChanges) => GetByCondition(x => x.UrunID == id, trackChanges).FirstOrDefault();

        public string ProductName(int id, bool trackChanges)
        {
            return GetByCondition(x => x.UrunID == id, trackChanges).First().Adi!;
        }

        #endregion
    }
}
