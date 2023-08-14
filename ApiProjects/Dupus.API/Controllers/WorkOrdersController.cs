using Dupus.API.Controllers.BaseController;
using Dupus.Service.Contracts.IServiceManagers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dupus.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkOrdersController : CustomBaseController
    {

        #region Constructor

        public WorkOrdersController(IServiceManager manager) : base(manager)
        {

        }

        #endregion

        #region Methods


        [HttpGet]
        //[Route("WorkOrderList")]
        public IActionResult GetAllWorkOrder()
        {

            var entity = _serviceManager.WorkOrderService.GetAllWorkOrder(false).Take(50);
            return CheckEntityResult(entity);
        }


        [HttpGet]
        [Route("WorkOrderListById/{id}")]
        public IActionResult? GetWorkOrderById(int id = 999999)
        {
            var entity = _serviceManager.WorkOrderService.GetWorkOrderById(id, false);
            return CheckEntityResult(entity) as IActionResult;

        }


        [HttpGet]
        [Route("WorkOrderStatusList")]
        public IActionResult GetAllWorkOrderStatus()
        {
            var entity = _serviceManager.WorkOrderService.GetAllWorkOrderStatus();
            return CheckEntityResult(entity);

        }

        [HttpGet]
        [Route("WorkOrderStatusById/{id}")]
        public IActionResult? GetWorkOrderStatusById([FromQuery] int id)
        {
            var entity = _serviceManager.WorkOrderService.GetWorkOrderStatusById(id);
            return CheckEntityResult(entity) as IActionResult;

        }

        [HttpGet]
        [Route("WeeklyPlanWorkOrdersById/{id}")]
        public IActionResult GetWeeklyPlanWorkOrders([FromRoute(Name = "id")] string id)
        {
            var entity = _serviceManager.WorkOrderService.GetWeeklyPlanWorkOrders(id);
            return CheckEntityResult(entity);

        }

        [HttpGet]
        [Route("GanttProductPlan")]
        public IActionResult? GanttProductPlan()
        {
            var entity = _serviceManager.WorkOrderService.GanttProductPlan();
            return CheckEntityResult(entity);

        }

        [HttpGet]
        [Route("GanttTasks")]
        public IActionResult GanttTasks()
        {
            var entity = _serviceManager.WorkOrderService.GanttTasks();
            return CheckEntityResult(entity);

        }


      




        #endregion
    }
}
