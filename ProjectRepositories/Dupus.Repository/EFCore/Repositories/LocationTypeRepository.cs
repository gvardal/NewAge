using Dupus.Entity.Models.ProductionManagment;
using Dupus.Repository.Contracts.IRepositories;
using Dupus.Repository.EFCore.RepositoryBases;
using Dupus.Repository.EFCore.RepositoryContexts;

namespace Dupus.Repository.EFCore.Repositories
{
    public class LocationTypeRepository : RepositoryBase<LocationsType>, ILocationTypeRepository
    {
        #region Constructor

        public LocationTypeRepository(RepositoryContext context) : base(context)
        {
        }

        #endregion

        #region Methods
        
        public IQueryable<LocationsType> GetAllLocationsType(bool trackChanges) => GetAll(trackChanges);

        public IQueryable<LocationsType> GetLocationTypeById(int id, bool trackChanges) => GetByCondition(x => x.KonumTuruID.Equals(id), trackChanges);

        #endregion
    }
}
