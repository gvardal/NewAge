using Dupus.Entity.Models.SalesManagment;
using Dupus.Repository.Contracts.IRepositories;
using Dupus.Repository.EFCore.RepositoryBases;
using Dupus.Repository.EFCore.RepositoryContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dupus.Repository.EFCore.Repositories
{
    public class OrdersRepository : RepositoryBase<Orders>, IOrdersRepository
    {
        #region Members

        public OrdersRepository(RepositoryContext context) : base(context)
        {

        }



        #endregion

        #region Methods

        public IQueryable<Orders> GetAllOrders(bool trackChanges) => GetAll(trackChanges);

        public IQueryable<Orders> GetOrderById(int id, bool trackChanges) => GetByCondition(x => x.SiparisID.Equals(id), trackChanges);

        #endregion
    }
}
