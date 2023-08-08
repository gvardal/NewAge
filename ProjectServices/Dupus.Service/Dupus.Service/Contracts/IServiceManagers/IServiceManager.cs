using ProjectServices.Dupus.Services.Contracts;

namespace Dupus.Service.Contracts.IServiceManagers
{
    public interface IServiceManager
    {
        IWorkOrderService WorkOrderService { get; }
        IWorkOrderRouteService WorkOrderRouteService { get; }
        ILocationTypeService LocationTypeService { get; }
        ILocationService LocationService { get; }
        IProductsService ProductsService { get; }
    }
}
