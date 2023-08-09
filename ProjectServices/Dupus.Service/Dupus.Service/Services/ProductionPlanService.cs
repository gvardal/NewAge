using Dupus.Entity.Models.ProductionManagment;
using Dupus.Entity.Models.SalesManagment;
using Dupus.Repository.Contracts.IRepositoryManagers;
using Dupus.Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dupus.Service.Services
{
    public class ProductionPlanService: IProductionPlanService
    {
        #region Members

        private readonly IRepositoryManager _repositoryManager;

        #endregion

        #region Constructor

        public ProductionPlanService(IRepositoryManager manager)
        {
            _repositoryManager = manager;
        }

        #endregion

        #region Methods

        public IEnumerable<ProductionPlan> GetAllProductionsPlan(bool trackChanges) => _repositoryManager.ProductionPlanRepository.GetAllProductionsPlan(trackChanges);

        public IEnumerable<ProductionPlan> GetProductionPlanById(int id, bool trackChanges) => _repositoryManager.ProductionPlanRepository.GetProductionPlanById(id, trackChanges);

        #endregion

    }
}
