using Models.Entities.Dupus.Entity.Dtos;
using Models.Entities.Dupus.Entity.Models;

namespace ProjectRepositories.Dupus.Repository.Contracts
{
    public interface IIsEmriRotaRepository : IRepositoryBase<UYIsEmriRotasi>
    {
        IQueryable<UYIsEmriRotasi> GetAllIsEmriRotaList(bool trackChanges);
        IQueryable<UYIsEmriRotasi> IsEmriRotasiById(int id,bool trackChanges);
        void UpdateIsEmriRotasi (UYIsEmriRotasi isEmriRotasi);
    }
}
