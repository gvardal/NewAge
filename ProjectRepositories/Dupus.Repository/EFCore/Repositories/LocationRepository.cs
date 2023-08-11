using Dupus.Entity.Models.ProductionManagment;
using Dupus.Repository.Contracts.IRepositories;
using Dupus.Repository.EFCore.RepositoryBases;
using Dupus.Repository.EFCore.RepositoryContexts;

namespace Dupus.Repository.EFCore.Repositories
{
    public class LocationRepository : RepositoryBase<Locations>, ILocationRepository
    {
        #region Constructor

        public LocationRepository(RepositoryContext context) : base(context)
        {
        }

        #endregion

        #region Methods

        public IQueryable<Locations> GetLocationById(int id, bool trackChanges) => GetByCondition(x => x.KonumID.Equals(id), trackChanges);

        public IQueryable<Locations> GetAllLocations(bool trackChanges) => GetAll(trackChanges);

        public IQueryable<Locations> GetLocationByLocationTypeId(int id, bool trackChanges) => GetByCondition(x => x.KonumTuruID == id, trackChanges);

        #endregion

    }
}
