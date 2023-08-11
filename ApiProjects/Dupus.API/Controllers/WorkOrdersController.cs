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
        [Route("WorkOrderList")]
        public IActionResult GetAllWorkOrder()
        {
            
            var entity = _serviceManager.WorkOrderService.GetAllWorkOrder(false).Take(50);
            if (entity == null)
                return NotFound();
            return Ok(entity);
        }

        /// <summary>
        /// It represent getting work order by id
        /// </summary>
        /// <param name="workOrderId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("WorkOrderListById")]
        public IActionResult GetWorkOrderById(int workOrderId = 999999)
        {
            var entity = _serviceManager.WorkOrderService.GetWorkOrderById(workOrderId, false);
            if (entity == null)
                return NotFound();
            return Ok(entity);
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
            if (entity == null)
                return NotFound();
            return Ok(entity);
        }

        /// <summary>
        /// It represent getting work order status by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("WorkOrderStatusById")]
        public IActionResult GetWorkOrderStatusById([FromQuery] int id)
        {
            var entity = _serviceManager.WorkOrderService.GetWorkOrderStatusById(id);
            if (entity == null)
                return NotFound();
            return Ok(entity);
        }

        #endregion
    }
}
