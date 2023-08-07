using Models.Entities.Dupus.Entity.Models;

namespace Services.Dupus.Services.Contracts
{
    public interface IKonumTuruService
    {
        IEnumerable<UYKonumTuru> GetAllKonumTuru(bool trackChanges);
    }
}
