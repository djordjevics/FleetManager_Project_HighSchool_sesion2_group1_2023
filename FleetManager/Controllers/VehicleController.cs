using FleetManager.Models;
using Microsoft.AspNetCore.Mvc;

namespace FleetManager.Controllers
{
    [ApiController]
    [Route("[controller]/{id}")]
    public class VehicleController : ControllerBase
    {
        private readonly ILogger<VehicleController> _logger;

        public VehicleController(ILogger<VehicleController> logger)
        {
            _logger = logger;
        }
        [HttpPut(Name = "UpdateVehicle")]
        public ActionResult Update(Guid id, PutVehicle updateRequest)
        {
            updateRequest.Id = id;
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteVehicle(int id)
        {
            throw new NotImplementedException();
        }
        [HttpPost(Name = "AddVehicle")]
        public ActionResult AddVehicle(Guid Id,AddVehicle AddRequest)
        {
            AddRequest.Id = Id;
            throw new NotImplementedException();
        }


    }
}
