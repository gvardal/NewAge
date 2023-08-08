using Dupus.Repository.Contracts.IRepositories;

namespace Dupus.Repository.Contracts.IRepositoryManagers
{
    public interface IRepositoryManager
    {
        IWorkOrderRepository WorkOrderRepository { get; }
        IWorkOrderRouteRepository WorkOrderRouteRepository { get; }
        ILocationTypeRepository LocationTypeRepository { get; }
        ILocationRepository LocationRepository { get; }
        IProductsRepository ProductsRepository { get; }
        void Save();
    }
}
