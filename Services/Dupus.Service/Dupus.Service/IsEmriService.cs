﻿using Models.Entities.Dupus.Entity.Dtos;
using Models.Entities.Dupus.Entity.Models;
using ProjectRepositories.Dupus.Repository.Contracts;
using Services.Dupus.Services.Contracts;

namespace Services.Dupus.Services
{
    public class IsEmriService : IIsEmriService
    {
        private readonly IRepositoryManager _manager;

        public IsEmriService(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public List<TaskData> GanttTasks()
        {
            var result = _manager.IsEmri.GanttTasks();
            return result;
        }

        public List<TaskData> GanttUretimPlani()
        {
            var result = _manager.IsEmri.GanttUretimPlani();
            return result;
        }

        public List<GanttMainTaskDto> GanttMainTasks()
        {
            var result = _manager.IsEmri.GanttMainTask();
            return result;
        }

        public IEnumerable<UYIsEmri> GetAllIsEmri(bool trackChanges) => _manager.IsEmri.GetAllIsEmriList(trackChanges).Take(5);

        public IEnumerable<UYIsEmriDurumu> GetAllIsEmriDurumu() => _manager.IsEmri.GetAllIsEmriDurumuList();

        public UYIsEmri? GetIsEmriById(int id, bool trackChanges) => _manager.IsEmri.IsEmriById(id, trackChanges).SingleOrDefault();

        public UYIsEmriDurumu? GetIsEmriDurumuById(int id) => _manager.IsEmri.GetIsEmriDurumuById(id);

        public IEnumerable<WeeklyPlanDto> GetWeeklyPlanWorkOrders(string konumId) => _manager.IsEmri.WeeklyPlanWorkOrders(konumId);
    }
}
