using AutoMapper;
using Models.Entities.Dupus.Entity.Dtos;
using Models.Entities.Dupus.Entity.Models;
using ProjectRepositories.Dupus.Repository.Contracts;
using Services.Dupus.Services.Contracts;

namespace Services.Dupus.Services
{
    public class KonumService : IKonumService
    {
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;

        public KonumService(IRepositoryManager manager, IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
        }

        public IEnumerable<GanttResourceGroupDto> GanttResourceGroup(byte id, bool trackChanges)
        {
            var konumList = _manager.UYKonum.GetAllKonumByKonumId(id, trackChanges);
            var resourceGroup = _mapper.Map<List<GanttResourceGroupDto>>(konumList);
            return resourceGroup;
        }

        public IEnumerable<UYKonum> GetAllKonumByKonumId(byte id, bool trackChanges) => _manager.UYKonum.GetAllKonumByKonumId(id, trackChanges);

        public IEnumerable<UYKonum> GetAllKonumList(bool trackChanges) => _manager.UYKonum.GetAllKonumList(trackChanges);

        
    }
}
