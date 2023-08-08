using Dupus.Repository.Contracts.IRepositoryBases;
using Models.Entities.Dupus.Entity.Dtos;
using Models.Entities.Dupus.Entity.Models;

namespace Dupus.Repository.Contracts.IRepositories
{
    public interface IWorkOrderRepository : IRepositoryBase<UYIsEmri>
    {
        IQueryable<UYIsEmri> GetAllWorkOrder(bool trackChanges);
        IQueryable<UYIsEmri> GetWorkOrderById(int id, bool trackChanges);
        IQueryable<UYIsEmriDurumu> GetAllWorkOrderStatus();
        UYIsEmriDurumu? GetWorkOrderStatusById(int id);


        #region Gantt

        List<TaskData> GanttTasks();
        List<GanttMainTaskDto> GanttMainTask();
        List<WeeklyPlanDto> WeeklyPlanWorkOrders(string konumId);
        List<TaskData> GanttProductPlan();

        #endregion
    }
}
