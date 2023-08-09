using Dupus.Entity.Models.ProductionManagment;
using Dupus.Repository.Contracts.IRepositoryManagers;
using ProjectServices.Dupus.Services.Contracts;

namespace Dupus.Service.Services
{
    public class LocationTypeService : ILocationTypeService
    {
        #region Members

        private readonly IRepositoryManager _repositoryManager;

        #endregion

        #region Constructor

        public LocationTypeService(IRepositoryManager manager)
        {
            _repositoryManager = manager;
        }

        #endregion

        #region Methods

        public IEnumerable<LocationsType> GetAllLocationsType(bool trackChanges) => _repositoryManager.LocationTypeRepository.GetAllLocationsType(trackChanges);

        public LocationsType? GetLocationTypeById(int id, bool trackChanges) => _repositoryManager.LocationTypeRepository.GetLocationTypeById(id, trackChanges).SingleOrDefault();


        #endregion

    }
}
