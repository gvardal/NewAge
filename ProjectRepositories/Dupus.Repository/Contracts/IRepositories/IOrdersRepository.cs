using Dupus.Entity.Models.ProductionManagment;
using Dupus.Entity.Models.SalesManagment;
using Dupus.Repository.Contracts.IRepositoryBases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dupus.Repository.Contracts.IRepositories
{
    public interface IOrdersRepository : IRepositoryBase<Orders>
    {
        IQueryable<Orders> GetAllOrders(bool trackChanges);
        IQueryable<Orders> GetOrderById(int id, bool trackChanges);
    }
}
