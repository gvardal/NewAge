using Dupus.Entity.Models.ProductionManagment;
using Dupus.Repository.Contracts.IRepositoryBases;
using Models.Entities.Dupus.Entity.Dtos;

namespace Dupus.Repository.Contracts.IRepositories
{
    public interface IWorkOrderRepository : IRepositoryBase<WorkOrder>
    {
        IQueryable<WorkOrder> GetAllWorkOrder(bool trackChanges);
        IQueryable<WorkOrder> GetWorkOrderById(int id, bool trackChanges);
        IQueryable<WorkOrderStatus> GetAllWorkOrderStatus();
        WorkOrderStatus? GetWorkOrderStatusById(int id);


        #region Gantt

        List<TaskData> GanttTasks();
        List<GanttMainTaskDto> GanttMainTask();
        List<WeeklyPlanDto> WeeklyPlanWorkOrders(string konumId);
        List<TaskData> GanttProductPlan();

        #endregion
    }
}
