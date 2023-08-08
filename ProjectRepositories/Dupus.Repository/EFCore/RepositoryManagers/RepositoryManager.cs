using Dupus.Repository.Contracts.IRepositories;
using Dupus.Repository.Contracts.IRepositoryManagers;
using Dupus.Repository.EFCore.Repositories;
using Dupus.Repository.EFCore.RepositoryContexts;

namespace Dupus.Repository.EFCore.RepositoryManagers
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _context;
        private readonly Lazy<IWorkOrderRouteRepository> _WorkOrderRouteRepository;
        private readonly Lazy<IWorkOrderRepository> _WorkOrderRepository;
        private readonly Lazy<ILocationTypeRepository> _LocationTypeRepository;
        private readonly Lazy<ILocationRepository> _LocationRepository;
        private readonly Lazy<IProductsRepository> _ProductsRepository;


        public RepositoryManager(RepositoryContext context)
        {
            _context = context;
            _WorkOrderRouteRepository = new Lazy<IWorkOrderRouteRepository>(() => new WorkOrderRouteRepository(_context));
            _WorkOrderRepository = new Lazy<IWorkOrderRepository>(() => new WorkOrderRepository(_context));
            _LocationTypeRepository = new Lazy<ILocationTypeRepository>(() => new LocationTypeRepository(_context));
            _LocationRepository = new Lazy<ILocationRepository>(() => new LocationRepository(_context));
            _ProductsRepository = new Lazy<IProductsRepository>(() => new ProductsRepository(_context));

        }

        public IWorkOrderRouteRepository WorkOrderRouteRepository => _WorkOrderRouteRepository.Value;
        public IWorkOrderRepository WorkOrderRepository => _WorkOrderRepository.Value;
        public ILocationTypeRepository LocationTypeRepository => _LocationTypeRepository.Value;
        public ILocationRepository LocationRepository => _LocationRepository.Value;
        public IProductsRepository ProductsRepository => _ProductsRepository.Value;

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
