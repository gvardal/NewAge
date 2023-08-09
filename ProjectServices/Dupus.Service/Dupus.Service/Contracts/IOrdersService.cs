using Dupus.Entity.Models.SalesManagment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dupus.Service.Contracts
{
    public interface IOrdersService
    {
        IEnumerable<Orders> GetAllOrders(bool trackChanges);
        IEnumerable<Orders> GetOrderById(int id, bool trackChanges);

    }
}
