using Dupus.Repository.Contracts.IRepositories;
using Dupus.Repository.EFCore.RepositoryBases;
using Dupus.Repository.EFCore.RepositoryContexts;
using Models.Entities.Dupus.Entity.Models;

namespace Dupus.Repository.EFCore.Repositories
{
    public class LocationTypeRepository : RepositoryBase<UYKonumTuru>, ILocationTypeRepository
    {
        #region Constructor

        public LocationTypeRepository(RepositoryContext context) : base(context)
        {
        }

        #endregion

        #region Methods
        
        public IQueryable<UYKonumTuru> GetAllLocationsType(bool trackChanges) => GetAll(trackChanges);

        public IQueryable<UYKonumTuru> GetLocationTypeById(int id, bool trackChanges) => GetByCondition(x => x.KonumTuruID.Equals(id), trackChanges);

        #endregion
    }
}
