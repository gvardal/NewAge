using Dupus.Entity.Models.ProductionManagment;
using Dupus.Repository.Contracts.IRepositoryManagers;
using ProjectServices.Dupus.Services.Contracts;

namespace Dupus.Service.Services
{
    public class WorkOrderRouteService : IWorkOrderRouteService
    {
        #region Members

        private readonly IRepositoryManager _repositoryManager;

        #endregion

        #region Constructor

        public WorkOrderRouteService(IRepositoryManager manager)
        {
            _repositoryManager = manager;
        }

        #endregion

        #region Methods

        public IQueryable<WorkOrderRoute> GetAllWorkOrderRoute(bool trackChanges) => _repositoryManager.WorkOrderRouteRepository.GetAllWorkOrderRoutes(trackChanges).Take(5);

        public IQueryable<WorkOrderRoute> GetWorkOrderRouteById(int isEmriRotaId, bool trackChanges) => _repositoryManager.WorkOrderRouteRepository.GetWorkOrderRouteById(isEmriRotaId, trackChanges);

        public string UpdateWorkOrderRoute(WorkOrderRoute isEmriRota)
        {
            _repositoryManager.WorkOrderRouteRepository.UpdateWorkOrderRoute(isEmriRota);
            _repositoryManager.Save();
            return $"{isEmriRota.IsEmriRotaID} Updated Successfully";
        }


        #endregion
    }
}
