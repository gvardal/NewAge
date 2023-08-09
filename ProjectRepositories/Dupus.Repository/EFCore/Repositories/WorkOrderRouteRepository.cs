using Dupus.Repository.EFCore.RepositoryBases;
using Dupus.Repository.EFCore.RepositoryContexts;
using Dupus.Repository.Contracts.IRepositories;
using Dupus.Entity.Models.ProductionManagment;

namespace Dupus.Repository.EFCore.Repositories
{
    public class WorkOrderRouteRepository : RepositoryBase<WorkOrderRoute>, IWorkOrderRouteRepository
    {
        #region Constructor

        public WorkOrderRouteRepository(RepositoryContext context) : base(context)
        {
        }

        #endregion

        #region  Methods

        public IQueryable<WorkOrderRoute> GetAllWorkOrderRoutes(bool trackChanges) => GetAll(trackChanges);

        public IQueryable<WorkOrderRoute> GetWorkOrderRouteById(int id, bool trackChanges)
        {
            IQueryable<WorkOrderRoute> result = GetByCondition(x => x.IsEmriRotaID.Equals(id), trackChanges);
            return result;
        }

        public void UpdateWorkOrderRoute(WorkOrderRoute workOrderRoute)
        {
            Update(workOrderRoute);
        }

        #endregion
    }
}
