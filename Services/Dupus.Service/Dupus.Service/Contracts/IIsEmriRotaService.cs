using Models.Entities.Dupus.Entity.Models;

namespace Services.Dupus.Services.Contracts
{
    public interface IIsEmriRotaService
    {
        string updateIsEmriRotasi(UYIsEmriRotasi isEmriRota);
        IQueryable<UYIsEmriRotasi> GetIsEmriRotaById(int isEmriRotaId, bool trackChanges);
    }
}
