using Dupus.Repository.Contracts.IRepositories;
using Dupus.Repository.EFCore.RepositoryBases;
using Dupus.Repository.EFCore.RepositoryContexts;
using Models.Entities.Dupus.Entity.Models;

namespace Dupus.Repository.EFCore.Repositories
{
    public class LocationRepository : RepositoryBase<UYKonum>, ILocationRepository
    {
        #region Constructor

        public LocationRepository(RepositoryContext context) : base(context)
        {
        }

        #endregion

        #region Methods

        public IQueryable<UYKonum> GetLocationById(byte id, bool trackChanges) => GetByCondition(x => x.KonumTuruID.Equals(id), trackChanges);

        public IQueryable<UYKonum> GetAllLocations(bool trackChanges) => GetAll(trackChanges);

        #endregion

    }
}
