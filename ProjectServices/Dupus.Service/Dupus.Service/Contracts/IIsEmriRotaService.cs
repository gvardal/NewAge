using Models.Entities.Dupus.Entity.Models;

namespace ProjectServices.Dupus.Services.Contracts
{
    public interface IIsEmriRotaService
    {
        string updateIsEmriRotasi(UYIsEmriRotasi isEmriRota);
        IQueryable<UYIsEmriRotasi> GetIsEmriRotaById(int isEmriRotaId, bool trackChanges);
    }
}
