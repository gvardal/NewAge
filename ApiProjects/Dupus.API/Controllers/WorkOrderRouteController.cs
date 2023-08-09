using Dupus.API.Controllers.BaseController;
using Dupus.Service.Contracts.IServiceManagers;
using Microsoft.AspNetCore.Mvc;

namespace Dupus.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkOrderRouteController : CustomBaseController
    {
       

        #region Constructor

        public WorkOrderRouteController(IServiceManager manager) : base(manager)
        {
           
        }

        #endregion

        #region Methods

        /// <summary>
        /// It represent all work order routes
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetAllWorkOrderRoutes()
        {
            var entity = _serviceManager.WorkOrderRouteService.GetAllWorkOrderRoute(false).Take(10);
            if (entity == null)
                return NotFound();
            return Ok(entity);
        }

        /// <summary>
        /// It represent getting work order route by id
        /// </summary>
        /// <param name="workOrderRouteId"></param>
        /// <returns></returns>
        [HttpGet("{workOrderRouteId:int}")]
        public IActionResult GetWorkOrderRouteById([FromRoute(Name = "workOrderRouteId")] int workOrderRouteId)
        {
            var entity = _serviceManager.WorkOrderRouteService.GetWorkOrderRouteById(workOrderRouteId, false);
            if (entity == null)
                return NotFound();
            return Ok(entity);
        }

        #endregion
    }
}
