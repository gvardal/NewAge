using Models.Entities.Dupus.Entity.Models;
using Dupus.Repository.EFCore.RepositoryBases;
using Dupus.Repository.EFCore.RepositoryContexts;
using Dupus.Repository.Contracts.IRepositories;

namespace Dupus.Repository.EFCore.Repositories
{
    public class WorkOrderRouteRepository : RepositoryBase<UYIsEmriRotasi>, IWorkOrderRouteRepository
    {
        #region Constructor

        public WorkOrderRouteRepository(RepositoryContext context) : base(context)
        {
        }

        #endregion

        #region  Methods

        public IQueryable<UYIsEmriRotasi> GetAllWorkOrderRoutes(bool trackChanges) => GetAll(trackChanges);

        public IQueryable<UYIsEmriRotasi> GetWorkOrderRouteById(int id, bool trackChanges)
        {
            IQueryable<UYIsEmriRotasi> result = GetByCondition(x => x.IsEmriRotaID.Equals(id), trackChanges);
            return result;
        }

        public void UpdateWorkOrderRoute(UYIsEmriRotasi workOrderRoute)
        {
            Update(workOrderRoute);
        }

        #endregion
    }
}
