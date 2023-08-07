using Models.Entities.Dupus.Entity.Models;

namespace ProjectServices.Dupus.Services.Contracts
{
    public interface IKonumTuruService
    {
        IEnumerable<UYKonumTuru> GetAllKonumTuru(bool trackChanges);
    }
}
