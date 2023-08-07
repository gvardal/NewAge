using Models.Entities.Dupus.Entity.Models;
using ProjectRepositories.Dupus.Repository.Contracts;

namespace ProjectRepositories.Dupus.Repository.EFCore
{
    public class UYKonumTuruRepository : RepositoryBase<UYKonumTuru>, IUYKonumTuruRepository
    {
        public UYKonumTuruRepository(RepositoryContext context) : base(context)
        {
        }

        public IQueryable<UYKonumTuru> GetAllKonumTuru(bool trackChanges) => GetAll(trackChanges);
    }
}
