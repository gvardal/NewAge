using Dupus.API.Controllers.BaseController;
using Dupus.Entity.Models.ProductionManagment;
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
            return CheckEntityResult(entity);

        }

        /// <summary>
        /// It represent getting work order route by id
        /// </summary>
        /// <param name="workOrderRouteId"></param>
        /// <returns></returns>
        [HttpGet("WorkOrderRouteById/{id}")]
        public IActionResult GetWorkOrderRouteById([FromRoute(Name = "id")] int id)
        {
            var entity = _serviceManager.WorkOrderRouteService.GetWorkOrderRouteById(id, false);
            return CheckEntityResult(entity);

        }

        [HttpPut("")]
        public IActionResult UpdateWorkOrderRoute(WorkOrderRoute item)
        {
            var entity = _serviceManager.WorkOrderRouteService.UpdateWorkOrderRoute(item);
            if (entity == null)
                return NotFound();
            return Ok(entity);

        }
        #endregion
    }
}
