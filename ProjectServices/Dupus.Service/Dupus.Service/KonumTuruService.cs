using Models.Entities.Dupus.Entity.Models;
using ProjectRepositories.Dupus.Repository.Contracts;
using ProjectServices.Dupus.Services.Contracts;

namespace ProjectServices.Dupus.Services
{
    public class KonumTuruService : IKonumTuruService
    {
        private readonly IRepositoryManager _manager;

        public KonumTuruService(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public IEnumerable<UYKonumTuru> GetAllKonumTuru(bool trackChanges) => _manager.UYKonumTuru.GetAllKonumTuru(trackChanges);
    }
}
