using Models.Entities.Dupus.Entity.Models;
using ProjectRepositories.Dupus.Repository.Contracts;
using ProjectServices.Dupus.Services.Contracts;

namespace ProjectServices.Dupus.Services
{
    public class UrunlerService : IUrunlerService
    {
        private readonly IRepositoryManager _manager;

        public UrunlerService(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public UYUrunler? GetUrunById(int id, bool trackChanges) => _manager.UYUrunler.GetUrunById(id, trackChanges);

        public IEnumerable<UYUrunler> GetUrunlerList(bool trackChanges) => _manager.UYUrunler.GetAllUrunList(trackChanges);
    }
}
