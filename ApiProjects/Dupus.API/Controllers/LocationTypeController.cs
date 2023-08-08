using Dupus.Service.Contracts.IServiceManagers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dupus.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationTypeController : ControllerBase
    {
        #region Members

        private readonly IServiceManager _serviceManager;

        #endregion

        #region Constructor

        public LocationTypeController(IServiceManager manager)
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
        public IActionResult GetAllLocationsType()
        {
            var entity = _serviceManager.LocationTypeService.GetAllLocationsType(false);
            if (entity == null)
                return NotFound();
            return Ok(entity);
        }


        /// <summary>
        /// It represent getting locations type by id
        /// </summary>
        /// <param name="locationTypeId"></param>
        /// <returns></returns>
        [HttpGet("{LocationTypeId:int}")]
        public IActionResult GetLocationTypeById([FromRoute(Name = "LocationTypeId")] byte locationTypeId)
        {
            var entity = _serviceManager.LocationTypeService.GetLocationTypeById(locationTypeId, false);
            if (entity == null)
                return NotFound();
            return Ok(entity);
        }
        #endregion
    }
}
