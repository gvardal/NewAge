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

        List<TaskData> GanttTasks();
        List<GanttMainTaskDto> GanttMainTasks();
        // For Blazor Project
        IEnumerable<WeeklyPlanDto> GetWeeklyPlanWorkOrders(string konumId);
        List<TaskData> GanttProductPlan();
        
        #endregion
    }
}
