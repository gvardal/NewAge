using AutoMapper;
using Dupus.Repository.Contracts.IRepositoryManagers;
using Models.Entities.Dupus.Entity.Dtos;
using Models.Entities.Dupus.Entity.Models;
using ProjectServices.Dupus.Services.Contracts;

namespace Dupus.Service.Services
{
    public class LocationService : ILocationService
    {

        #region Members

        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        #endregion

        #region Constructor

        public LocationService(IRepositoryManager manager, IMapper mapper)
        {
            _repositoryManager = manager;
            _mapper = mapper;
        }

        #endregion

        #region Methods

        public IEnumerable<UYKonum> GetAllLocations(bool trackChanges) => _repositoryManager.LocationRepository.GetAllLocations(trackChanges);


        public IEnumerable<UYKonum> GetLocationById(byte id, bool trackChanges) => _repositoryManager.LocationRepository.GetLocationById(id, trackChanges);


        public IEnumerable<GanttResourceGroupDto> GanttResourceGroup(byte id, bool trackChanges)
        {
            var locationList = _repositoryManager.LocationRepository.GetLocationById(id, trackChanges);
            var resourceGroup = _mapper.Map<List<GanttResourceGroupDto>>(locationList);
            return resourceGroup;
        }

        #endregion
    }
}
