using Dupus.Repository.Contracts.IRepositoryManagers;
using Models.Entities.Dupus.Entity.Models;
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

        public IQueryable<UYIsEmriRotasi> GetAllWorkOrderRoute(bool trackChanges) => _repositoryManager.WorkOrderRouteRepository.GetAllWorkOrderRoutes(trackChanges).Take(5);

        public IQueryable<UYIsEmriRotasi> GetWorkOrderRouteById(int isEmriRotaId, bool trackChanges) => _repositoryManager.WorkOrderRouteRepository.GetWorkOrderRouteById(isEmriRotaId, trackChanges);

        public string UpdateWorkOrderRoute(UYIsEmriRotasi isEmriRota)
        {
            _repositoryManager.WorkOrderRouteRepository.UpdateWorkOrderRoute(isEmriRota);
            _repositoryManager.Save();
            return $"{isEmriRota.IsEmriRotaID} Updated Successfully";
        }


        #endregion
    }
}
