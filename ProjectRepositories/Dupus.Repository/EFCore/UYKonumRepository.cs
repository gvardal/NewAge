using Models.Entities.Dupus.Entity.Models;
using ProjectRepositories.Dupus.Repository.Contracts;
using ProjectRepositories.Dupus.Repository.EFCore;

namespace DProjectRepositories.Dupus.Repository.EFCore
{
    public class UYKonumRepository : RepositoryBase<UYKonum>, IUYKonumRepository
    {
        public UYKonumRepository(RepositoryContext context) : base(context)
        {
        }

        public IQueryable<UYKonum> GetAllKonumByKonumId(byte id, bool trackChanges) => GetByCondition(x=> x.KonumTuruID.Equals(id),trackChanges);

        public IQueryable<UYKonum> GetAllKonumList(bool trackChanges) => GetAll(trackChanges);
    }
}
