﻿using ProjectRepositories.Dupus.Repository.Contracts;
using Models.Entities.Dupus.Entity.Models;

namespace ProjectRepositories.Dupus.Repository.EFCore
{
    public class IsEmriRotaRepository : RepositoryBase<UYIsEmriRotasi>, IIsEmriRotaRepository
    {
        public IsEmriRotaRepository(RepositoryContext context) : base(context)
        {
        }

        public IQueryable<UYIsEmriRotasi> GetAllIsEmriRotaList(bool trackChanges) => GetAll(trackChanges);

        public IQueryable<UYIsEmriRotasi> IsEmriRotasiById(int id, bool trackChanges)
        {
            IQueryable<UYIsEmriRotasi> result = GetByCondition(x => x.IsEmriRotaID.Equals(id), trackChanges);
            return result;
        }

        public void UpdateIsEmriRotasi(UYIsEmriRotasi isEmriRotasi)
        {
            Update(isEmriRotasi);
            
        }
    }
}
