using Dupus.Entity.Models.ProductionManagment;
using Dupus.Repository.Contracts.IRepositoryManagers;
using Models.Entities.Dupus.Entity.Dtos;
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

        public IEnumerable<WorkOrder> GetAllWorkOrder(bool trackChanges) => _repositoryManager.WorkOrderRepository.GetAllWorkOrder(trackChanges).Take(5);

        public WorkOrder? GetWorkOrderById(int id, bool trackChanges) => _repositoryManager.WorkOrderRepository.GetWorkOrderById(id, trackChanges).SingleOrDefault();

        public IEnumerable<WorkOrderStatus> GetAllWorkOrderStatus() => _repositoryManager.WorkOrderRepository.GetAllWorkOrderStatus();

        public WorkOrderStatus? GetWorkOrderStatusById(int id) => _repositoryManager.WorkOrderRepository.GetWorkOrderStatusById(id);

        #region Gantt

        public IEnumerable<WeeklyPlanDto> GetWeeklyPlanWorkOrders(string konumId)
        {
            var result = _repositoryManager.WorkOrderRepository.WeeklyPlanWorkOrders(konumId);

            List<WeeklyPlanDto> list = new();
            foreach (var item in result)
            {
              
                var endDate = DateTime.Parse(item.EndTime.ToString("dd.MM.yyyy"));
                var startDate = DateTime.Parse(item.StartTime.ToString("dd.MM.yyyy"));

                double rslt = item.EndTime.Subtract(item.StartTime).TotalDays;
                if (endDate != startDate && (rslt > 0 || endDate.Day != startDate.Day))
                {
                    var count = (endDate.Day - startDate.Day);
                    for (int i = 0; i < (endDate.Day - startDate.Day) + 1; i++)
                    {
                        WeeklyPlanDto wordDto = new WeeklyPlanDto
                        {
                            Id = item.Id,
                            StartTime = item.StartTime,
                            EndTime = item.EndTime,
                            Description = item.Description,
                            IsAllDay = item.IsAllDay,
                            Location = item.Location,
                            RecurrenceException = item.RecurrenceException,
                            RecurrenceID = item.RecurrenceID,
                            RecurrenceRule = item.RecurrenceRule,
                            Subject = item.Subject
                            
                        };

                        if (i == 0)
                        {
                            wordDto.StartTime = item.StartTime;
                            wordDto.EndTime = startDate.AddDays(1).AddMinutes(-1);
                        }
                        else if (i == endDate.Day - startDate.Day)
                        {
                            wordDto.StartTime = endDate;
                            wordDto.EndTime = item.EndTime;
                        }
                        else
                        {
                            wordDto.StartTime = startDate.AddDays(i);
                            wordDto.EndTime = startDate.AddDays(i).AddDays(1).AddMinutes(-1);
                        }

                        list.Add(wordDto);
                    }
                }
                else if (endDate == startDate
                                   && item.EndTime.TimeOfDay.TotalMilliseconds != item.StartTime.TimeOfDay.TotalMilliseconds
                                   && item.EndTime.TimeOfDay.TotalMilliseconds > item.StartTime.TimeOfDay.TotalMilliseconds)
                {
                    list.Add(item);
                }

            }

            return list;
            //var temp = result.ToList().Where(x => (DateTime.Parse(x.EndTime.ToString("dd.MM.yyyy")) == (DateTime.Parse(x.StartTime.ToString("dd.MM.yyyy")))) || ).ToList();
            //return result.ToList().Where(x => (DateTime.Parse(x.EndTime.ToString("dd.MM.yyy")) != (DateTime.Parse(x.StartTime.ToString("dd.MM.yyyy"))))).ToList();

        }
        public IEnumerable<TaskData> GanttTasks()
        {
            var result = _repositoryManager.WorkOrderRepository.GanttTasks();
            return result;
        }

        public IEnumerable<TaskData> GanttProductPlan()
        {
            var result = _repositoryManager.WorkOrderRepository.GanttProductPlan();
            return result;
        }

        public IEnumerable<GanttMainTaskDto> GanttMainTasks()
        {
            var result = _repositoryManager.WorkOrderRepository.GanttMainTask();
            return result;
        }

        #endregion

        #endregion
    }
}
