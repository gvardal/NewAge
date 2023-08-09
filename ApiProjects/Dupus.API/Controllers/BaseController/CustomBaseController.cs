using Dupus.Service.Contracts.IServiceManagers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dupus.API.Controllers.BaseController
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomBaseController : ControllerBase
    {
        protected readonly IServiceManager _serviceManager;

        public CustomBaseController(IServiceManager manager)
        {
            _serviceManager = manager;
        }
    }
}
