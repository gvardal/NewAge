using Dupus.Service.Contracts.IServiceManagers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dupus.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {

        #region Members

        private readonly IServiceManager _serviceManager;

        #endregion

        #region Constructor

        public LocationController(IServiceManager manager)
        {
            _serviceManager = manager;
        }

        #endregion

        #region Methods

        /// <summary>
        /// It represent all locations type list
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetAllLocations()
        {
            var entity = _serviceManager.LocationService.GetAllLocations(false).Take(5);
            if (entity == null)
                return NotFound();
            return Ok(entity);
        }


        /// <summary>
        /// It represent getting locations  by id
        /// </summary>
        /// <param name="locationTypeId"></param>
        /// <returns></returns>
        [HttpGet("{LocationId:int}")]
        public IActionResult GetLocationById([FromRoute(Name = "LocationId")] byte locationId)
        {
            var entity = _serviceManager.LocationService.GetLocationById(locationId, false);
            if (entity == null)
                return NotFound();
            return Ok(entity);
        }

        #endregion
    }
}
