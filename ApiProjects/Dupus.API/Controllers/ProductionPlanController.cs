using Dupus.API.Controllers.BaseController;
using Dupus.Repository.EFCore.RepositoryManagers;
using Dupus.Service.Contracts.IServiceManagers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dupus.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductionPlanController : CustomBaseController
    {
        public ProductionPlanController(IServiceManager manager):base(manager)
        {
            
        }

        #region Methods

        [HttpGet]
        public IActionResult GetAllProductionsPlan()
        {
            var entity = _serviceManager.ProductionPlanService.GetAllProductionsPlan(false).Take(5);
            if (entity == null)
                return NotFound();
            return Ok(entity);
        }

        [HttpGet("{ProductionPlanId:int}")]
        public IActionResult GetProductionPlanById([FromRoute(Name = "ProductionPlanId")] int ordersId)
        {
            var entity = _serviceManager.ProductionPlanService.GetProductionPlanById(ordersId, false);
            if (entity == null)
                return NotFound();
            return Ok(entity);
        }

        #endregion
    }
}
