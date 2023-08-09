using Dupus.Entity.Models.ProductionManagment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dupus.Service.Contracts
{
    public interface IProductionPlanService
    {

        IEnumerable<ProductionPlan> GetAllProductionsPlan(bool trackChanges);
        IEnumerable<ProductionPlan> GetProductionPlanById(int id, bool trackChanges);
    }
}
