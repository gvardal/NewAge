using ProjectRepositories.Dupus.Repository.Contracts;
using Models.Entities.Dupus.Entity.Models;

namespace ProjectRepositories.Dupus.Repository.EFCore
{
    public class UYUrunlerRepository : RepositoryBase<UYUrunler>, IUYUrunlerRepository
    {
        public UYUrunlerRepository(RepositoryContext context) : base(context)
        {
        }

        public IQueryable<UYUrunler> GetAllUrunList(bool trackChanges) => GetAll(trackChanges);

        public UYUrunler? GetUrunById(int id, bool trackChanges) => GetByCondition(x => x.UrunID == id,trackChanges).FirstOrDefault();

        public string UrunAdi(int id, bool trackChanges)
        {
            return GetByCondition(x => x.UrunID == id, trackChanges).First().Adi!;
        }
    }
}
