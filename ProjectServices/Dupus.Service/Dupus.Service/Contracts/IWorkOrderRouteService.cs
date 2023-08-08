using Models.Entities.Dupus.Entity.Models;

namespace ProjectServices.Dupus.Services.Contracts
{
    public interface IWorkOrderRouteService
    {
        IQueryable<UYIsEmriRotasi> GetAllWorkOrderRoute(bool trackChanges);
        IQueryable<UYIsEmriRotasi> GetWorkOrderRouteById(int workOrderRouteId, bool trackChanges);
        string UpdateWorkOrderRoute(UYIsEmriRotasi workOrderRoute);

    }
}
