using Models.Entities.Dupus.Entity.Models;
using ProjectRepositories.Dupus.Repository.Contracts;
using Services.Dupus.Services.Contracts;

namespace Services.Dupus.Services
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
