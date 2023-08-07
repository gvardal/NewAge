using Models.Entities.Dupus.Entity.Models;

namespace Services.Dupus.Services.Contracts
{
    public interface IUrunlerService
    {
        IEnumerable<UYUrunler> GetUrunlerList(bool trackChanges);
        UYUrunler? GetUrunById(int id, bool trackChanges);
    }
}
