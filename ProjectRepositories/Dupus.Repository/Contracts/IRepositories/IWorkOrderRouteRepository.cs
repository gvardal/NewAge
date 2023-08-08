using Dupus.Repository.Contracts.IRepositoryBases;
using Models.Entities.Dupus.Entity.Dtos;
using Models.Entities.Dupus.Entity.Models;

namespace Dupus.Repository.Contracts.IRepositories
{
    public interface IWorkOrderRouteRepository : IRepositoryBase<UYIsEmriRotasi>
    {
        IQueryable<UYIsEmriRotasi> GetAllWorkOrderRoutes(bool trackChanges);
        IQueryable<UYIsEmriRotasi> GetWorkOrderRouteById(int id, bool trackChanges);
        void UpdateWorkOrderRoute(UYIsEmriRotasi workOrderRoute);
    }
}
