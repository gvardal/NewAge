using AutoMapper;
using Dupus.Repository.Contracts.IRepositoryManagers;
using Dupus.Service.Contracts;
using Dupus.Service.Contracts.IServiceManagers;
using Dupus.Service.Services;
using ProjectServices.Dupus.Services.Contracts;

namespace Dupus.Service.ServiceManagers
{
    public class ServiceManager : IServiceManager
    {
        private readonly IMapper _mapper;

        private readonly Lazy<IWorkOrderRouteService> _WorkOrderRouteService;
        private readonly Lazy<IWorkOrderService> _WorkOrderService;
        private readonly Lazy<ILocationTypeService> _LocationTypeService;
        private readonly Lazy<ILocationService> _LocationService;
        private readonly Lazy<IProductsService> _ProductsService;
        private readonly Lazy<IOrdersService> _OrdersService;
        private readonly Lazy<IProductionPlanService> _ProductionPlanService;
        public ServiceManager(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _mapper = mapper;
            _WorkOrderService = new Lazy<IWorkOrderService>(() => new WorkOrderService(repositoryManager));
            _WorkOrderRouteService = new Lazy<IWorkOrderRouteService>(() => new WorkOrderRouteService(repositoryManager));
            _LocationTypeService = new Lazy<ILocationTypeService>(() => new LocationTypeService(repositoryManager));
            _LocationService = new Lazy<ILocationService>(() => new LocationService(repositoryManager, mapper));
            _ProductsService = new Lazy<IProductsService>(() => new ProductsService(repositoryManager));
            _OrdersService = new Lazy<IOrdersService>(() => new OrdersService(repositoryManager));
            _ProductionPlanService = new Lazy<IProductionPlanService>(() => new ProductionPlanService(repositoryManager));


        }

        public IWorkOrderRouteService WorkOrderRouteService => _WorkOrderRouteService.Value;
        public IWorkOrderService WorkOrderService => _WorkOrderService.Value;
        public ILocationTypeService LocationTypeService => _LocationTypeService.Value;
        public ILocationService LocationService => _LocationService.Value;
        public IProductsService ProductsService => _ProductsService.Value;
        public IOrdersService OrdersService => _OrdersService.Value;
        public IProductionPlanService ProductionPlanService => _ProductionPlanService.Value;
    }
}
