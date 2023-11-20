using FleetManager.Models;
using Microsoft.AspNetCore.Mvc;

namespace FleetManager.Controllers;

[ApiController]
[Route("[controller]")]
public class VehicleController : ControllerBase
{
    private readonly ILogger<VehicleController> _logger;

    public VehicleController(ILogger<VehicleController> logger)
    {
        _logger = logger;
    }

    [HttpPut("{id}",Name ="UpdateVehicle")]
    public ActionResult Update(Guid id, PutVehicle updateRequest)
    {
        updateRequest.Id = id;
        throw new NotImplementedException();
    }

    [HttpDelete("{id}")]
    public ActionResult DeleteVehicle(Guid id)
    {
        throw new NotImplementedException();
    }
        [HttpPost(Name = "AddVehicle")]
        public ActionResult AddVehicle(Guid Id,AddVehicle AddRequest)
        {
            AddRequest.Id = Id;
            throw new NotImplementedException();
        }

        [HttpGet(Name = "GetAllVehicles")]
        public List<Vehicle> Get(){
            throw new NotImplementedException();
        }
}
