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

        /// <summary>
        /// It represent all work order list 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        //[Route("WorkOrderList")]
        public IActionResult GetAllWorkOrder()
        {

            var entity = _serviceManager.WorkOrderService.GetAllWorkOrder(false).Take(50);
            return CheckEntityResult(entity);
        }

        /// <summary>
        /// It represent getting work order by id
        /// </summary>
        /// <param name="workOrderId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("WorkOrderListById/{id}")]
        public IActionResult? GetWorkOrderById(int id = 999999)
        {
            var entity = _serviceManager.WorkOrderService.GetWorkOrderById(id, false);
            return CheckEntityResult(entity) as IActionResult;

        }

        /// <summary>
        /// It representing all work order status list
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("WorkOrderStatusList")]
        public IActionResult GetAllWorkOrderStatus()
        {
            var entity = _serviceManager.WorkOrderService.GetAllWorkOrderStatus();
            return CheckEntityResult(entity);

        }

        /// <summary>
        /// It represent getting work order status by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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


        #endregion
    }
}
