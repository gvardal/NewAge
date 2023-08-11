using Dupus.API.Controllers.BaseController;
using Dupus.Service.Contracts.IServiceManagers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dupus.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : CustomBaseController
    {
        #region Constructor

        public LocationController(IServiceManager manager) : base(manager)
        {

        }

        #endregion

        #region Methods


        [HttpGet]
        public object? GetAllLocations()
        {
            var entity = _serviceManager.LocationService.GetAllLocations(false).ToList();
            return CheckEntityResult(entity);
        }


        [HttpGet("LocationId/{id}")]
        public IActionResult GetLocationById([FromRoute(Name = "id")] int locationId)
        {
            var entity = _serviceManager.LocationService.GetLocationById(locationId, false);
            return CheckEntityResult(entity);
        }

        [HttpGet("LocationTypeId/{id}")]
        public IActionResult GetLocationByLocationTypeId([FromRoute(Name = "id")] int locationTypeId)
        {
            var entity = _serviceManager.LocationService.GetLocationByLocationTypeId(locationTypeId, false);
           
            return CheckEntityResult(entity);
        }

        [HttpGet("GantResource/{id}")]
        public IActionResult GanttResourceGroup([FromRoute(Name = "id")] byte id)
        {
            var entity = _serviceManager.LocationService.GanttResourceGroup(id, false);

            return CheckEntityResult(entity);
        }

        #endregion
    }
}
