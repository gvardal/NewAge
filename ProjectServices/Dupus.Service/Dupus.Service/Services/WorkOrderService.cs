using Dupus.Repository.Contracts.IRepositoryManagers;
using Models.Entities.Dupus.Entity.Dtos;
using Models.Entities.Dupus.Entity.Models;
using ProjectServices.Dupus.Services.Contracts;

namespace Dupus.Service.Services
{
    public class WorkOrderService : IWorkOrderService
    {
        #region Members

        private readonly IRepositoryManager _repositoryManager;

        #endregion

        #region Constructor

        public WorkOrderService(IRepositoryManager manager)
        {
            _repositoryManager = manager;
        }

        #endregion

        #region Methods

        public IEnumerable<UYIsEmri> GetAllWorkOrder(bool trackChanges) => _repositoryManager.WorkOrderRepository.GetAllWorkOrder(trackChanges).Take(5);

        public UYIsEmri? GetWorkOrderById(int id, bool trackChanges) => _repositoryManager.WorkOrderRepository.GetWorkOrderById(id, trackChanges).SingleOrDefault();

        public IEnumerable<UYIsEmriDurumu> GetAllWorkOrderStatus() => _repositoryManager.WorkOrderRepository.GetAllWorkOrderStatus();

        public UYIsEmriDurumu? GetWorkOrderStatusById(int id) => _repositoryManager.WorkOrderRepository.GetWorkOrderStatusById(id);

        #region Gantt

        public IEnumerable<WeeklyPlanDto> GetWeeklyPlanWorkOrders(string konumId) => _repositoryManager.WorkOrderRepository.WeeklyPlanWorkOrders(konumId);

        public List<TaskData> GanttTasks()
        {   
            var result = _repositoryManager.WorkOrderRepository.GanttTasks();
            return result;
        }

        public List<TaskData> GanttProductPlan()
        {
            var result = _repositoryManager.WorkOrderRepository.GanttProductPlan();
            return result;
        }

        public List<GanttMainTaskDto> GanttMainTasks()
        {
            var result = _repositoryManager.WorkOrderRepository.GanttMainTask();
            return result;
        }

        #endregion

        #endregion
    }
}
