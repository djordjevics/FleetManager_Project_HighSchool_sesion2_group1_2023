using BusinessLogic.Services;
using FleetManager.Models;
using Microsoft.AspNetCore.Mvc;

namespace FleetManager.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FuelLogController : ControllerBase
    {
        private readonly ILogger<FuelLogController> _logger;

        private IFuelLogService _fuelLogService;
        
        public FuelLogController(ILogger<FuelLogController> logger)
        {
            _logger = logger;
            _fuelLogService = new FuelLogService();
        }

        [HttpGet]
        public ActionResult GetAllFuelLogs()
        {
           return Ok(_fuelLogService.GetAllFuelLogs());
        }

        [HttpGet("{id}",Name = "GetById")]
        public ActionResult GetById(Guid Id)
        {
            throw new NotImplementedException();
        }

        [HttpGet("Vehicle/{vehicleId}",Name ="LogsByVehicle")]
        public IActionResult GetLogsByCarId()
        {
            throw new NotImplementedException();
        }

        [HttpPost(Name ="AddLog")]
        public IActionResult Post(FuelLog fuelLog)
        {
            fuelLog.Id = Guid.NewGuid();
            throw new NotImplementedException();
        }

        [HttpDelete("{id}", Name = "DeleteFuelLog")]
        public ActionResult Delete(Guid id)
        {
            throw new NotImplementedException();
        }
        
    }
}
