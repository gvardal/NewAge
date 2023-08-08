using Models.Entities.Dupus.Entity.Dtos;
using Models.Entities.Dupus.Entity.Models;

namespace ProjectServices.Dupus.Services.Contracts
{
    public interface IWorkOrderService
    {
        IEnumerable<UYIsEmri> GetAllWorkOrder(bool trackChanges);
        UYIsEmri? GetWorkOrderById(int id, bool trackChanges);
        IEnumerable<UYIsEmriDurumu> GetAllWorkOrderStatus();
        UYIsEmriDurumu? GetWorkOrderStatusById(int id);

        #region Gantt

        List<TaskData> GanttTasks();
        List<GanttMainTaskDto> GanttMainTasks();
        // For Blazor Project
        IEnumerable<WeeklyPlanDto> GetWeeklyPlanWorkOrders(string konumId);
        List<TaskData> GanttProductPlan();
        
        #endregion
    }
}
