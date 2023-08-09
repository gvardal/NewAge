using Dupus.Entity.Models.ProductionManagment;
using Dupus.Repository.Contracts.IRepositoryBases;
using Models.Entities.Dupus.Entity.Dtos;

namespace Dupus.Repository.Contracts.IRepositories
{
    public interface IWorkOrderRouteRepository : IRepositoryBase<WorkOrderRoute>
    {
        IQueryable<WorkOrderRoute> GetAllWorkOrderRoutes(bool trackChanges);
        IQueryable<WorkOrderRoute> GetWorkOrderRouteById(int id, bool trackChanges);
        void UpdateWorkOrderRoute(WorkOrderRoute workOrderRoute);
    }
}
