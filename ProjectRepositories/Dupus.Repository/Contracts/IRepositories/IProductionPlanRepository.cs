using Dupus.Entity.Models.ProductionManagment;
using Dupus.Entity.Models.SalesManagment;
using Dupus.Repository.Contracts.IRepositoryBases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dupus.Repository.Contracts.IRepositories
{
    public interface IProductionPlanRepository : IRepositoryBase<ProductionPlan>
    {
        IQueryable<ProductionPlan> GetAllProductionsPlan(bool trackChanges);
        IQueryable<ProductionPlan> GetProductionPlanById(int id, bool trackChanges);

    }
}
