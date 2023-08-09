using Dupus.Entity.Models.ProductionManagment;

namespace ProjectServices.Dupus.Services.Contracts
{
    public interface IWorkOrderRouteService
    {
        IQueryable<WorkOrderRoute> GetAllWorkOrderRoute(bool trackChanges);
        IQueryable<WorkOrderRoute> GetWorkOrderRouteById(int workOrderRouteId, bool trackChanges);
        string UpdateWorkOrderRoute(WorkOrderRoute workOrderRoute);

    }
}
