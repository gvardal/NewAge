using Dupus.Entity.Models.SalesManagment;
using Dupus.Repository.Contracts.IRepositoryManagers;
using Dupus.Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dupus.Service.Services
{
    public class OrdersService : IOrdersService
    {
        #region Members

        private readonly IRepositoryManager _repositoryManager;

        #endregion

        #region Constructor

        public OrdersService(IRepositoryManager manager)
        {
            _repositoryManager = manager;
        }

        #endregion

        #region Methods

        public IEnumerable<Orders> GetAllOrders(bool trackChanges) => _repositoryManager.OrdersRepository.GetAllOrders(trackChanges);

        public IEnumerable<Orders> GetOrderById(int id, bool trackChanges) => _repositoryManager.OrdersRepository.GetOrderById(id, trackChanges);

        #endregion
    }
}
