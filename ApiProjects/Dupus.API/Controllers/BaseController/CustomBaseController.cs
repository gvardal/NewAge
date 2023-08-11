using Azure;
using Dupus.Service.Contracts.IServiceManagers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Dynamic;

namespace Dupus.API.Controllers.BaseController
{

    public class CustomBaseController : ControllerBase
    {
        protected readonly IServiceManager _serviceManager;

        public CustomBaseController(IServiceManager manager)
        {
            _serviceManager = manager;
        }

        public IActionResult CheckEntityResult<T>(IEnumerable<T> entity) where T : class
        {
            if (entity == null || entity.Count() == 0)
                return NotFound();
            return Ok(entity);
        }


        public T? CheckEntityResult<T>(T entity) where T : new()
        {
            if (entity == null)
                return entity;
            return entity;
        }

    }
}
