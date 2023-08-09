using Dupus.Entity.Models.ProductionManagment;
using Dupus.Entity.Models.SalesManagment;
using Dupus.Repository.Contracts.IRepositories;
using Dupus.Repository.EFCore.RepositoryBases;
using Dupus.Repository.EFCore.RepositoryContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dupus.Repository.EFCore.Repositories
{
    public class ProductionPlanRepository : RepositoryBase<ProductionPlan>, IProductionPlanRepository
    {
        public ProductionPlanRepository(RepositoryContext context) : base(context)
        {

        }


        public IQueryable<ProductionPlan> GetAllProductionsPlan(bool trackChanges) => GetAll(trackChanges);

        public IQueryable<ProductionPlan> GetProductionPlanById(int id, bool trackChanges) => GetByCondition(x => x.UretimPlaniID.Equals(id), trackChanges);
    }
}
