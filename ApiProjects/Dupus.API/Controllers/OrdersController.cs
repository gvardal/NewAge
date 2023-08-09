using Dupus.API.Controllers.BaseController;
using Dupus.Service.Contracts.IServiceManagers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dupus.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : CustomBaseController
    {
        #region Constructor

        public OrdersController(IServiceManager manager) : base(manager)
        {

        }

        #endregion

        #region Methods

        [HttpGet]
        public IActionResult GetAllOrders()
        {
            var entity = _serviceManager.OrdersService.GetAllOrders(false).Take(5);
            if (entity == null)
                return NotFound();
            return Ok(entity);
        }

        [HttpGet("{OrdersId:int}")]
        public IActionResult GetOrderById([FromRoute(Name = "OrdersId")] int ordersId)
        {
            var entity = _serviceManager.OrdersService.GetOrderById(ordersId, false);
            if (entity == null)
                return NotFound();
            return Ok(entity);
        }

        #endregion
    }
}
