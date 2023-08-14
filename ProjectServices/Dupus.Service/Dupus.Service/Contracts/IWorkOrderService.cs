using Dupus.Entity.Models.ProductionManagment;
using Models.Entities.Dupus.Entity.Dtos;

namespace ProjectServices.Dupus.Services.Contracts
{
    public interface IWorkOrderService
    {
        IEnumerable<WorkOrder> GetAllWorkOrder(bool trackChanges);
        WorkOrder? GetWorkOrderById(int id, bool trackChanges);
        IEnumerable<WorkOrderStatus> GetAllWorkOrderStatus();
        WorkOrderStatus? GetWorkOrderStatusById(int id);

        #region Gantt

        IEnumerable<TaskData> GanttTasks();
        IEnumerable<GanttMainTaskDto> GanttMainTasks();
        // For Blazor Project
        IEnumerable<WeeklyPlanDto> GetWeeklyPlanWorkOrders(string konumId);
        IEnumerable<TaskData> GanttProductPlan();

        #endregion
    }
}
