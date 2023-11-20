using FleetManager.Models;
using Microsoft.AspNetCore.Mvc;

namespace FleetManager.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VehicleController : ControllerBase
    {
        private readonly ILogger<VehicleController> _logger;

        public VehicleController(ILogger<VehicleController> logger)
        {
            _logger = logger;
        }
        [HttpPost(Name = "AddVehicle")]
        public ActionResult AddVehicle(Guid Id,AddVehicle AddRequest)
        {
            AddRequest.Id = Id;
            throw new NotImplementedException();
        }


    }
}