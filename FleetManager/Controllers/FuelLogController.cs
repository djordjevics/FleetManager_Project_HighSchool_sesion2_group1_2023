using Microsoft.AspNetCore.Mvc;

namespace FleetManager.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FuelLogController : ControllerBase
    {
        private readonly ILogger<FuelLogController> _logger;
        public FuelLogController(ILogger<FuelLogController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public ActionResult GetAllFuelLogs()
        {
            throw new NotImplementedException();
        }

        [HttpGet("{vehicleId}",Name ="LogsByVehicle")]
        public IActionResult Get()
        {
            throw new NotImplementedException();
        }
    }
}
