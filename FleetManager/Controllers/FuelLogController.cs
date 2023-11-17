using Microsoft.AspNetCore.Mvc;

namespace FleetManager.Controllers
{
    public class FuelLogController : ControllerBase
    {
        private readonly ILogger<FuelLogController> _logger;
        public FuelLogController(ILogger<FuelLogController> logger)
        {
            _logger = logger;
        }
    }
}
