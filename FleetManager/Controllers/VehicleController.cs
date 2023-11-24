using BusinessLogic.Services;
using FleetManager.Models;
using Microsoft.AspNetCore.Mvc;

namespace FleetManager.Controllers;

[ApiController]
[Route("[controller]")]
public class VehicleController : ControllerBase
{
    private readonly ILogger<VehicleController> _logger;

    private IVehicleService _vehicleService;
    public VehicleController(ILogger<VehicleController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetAllVehicles")]
    public List<Vehicle> Get()
    {
        throw new NotImplementedException();
    }

    [HttpPut("{id}",Name ="UpdateVehicle")]
    public ActionResult Update(Guid id, PutVehicle updateRequest)
    {
        updateRequest.Id = id;
        throw new NotImplementedException();
    }

    [HttpPost(Name = "AddVehicle")]
    public ActionResult AddVehicle(Guid Id,AddVehicle AddRequest)
    {
        AddRequest.Id = Id;
        var result = _vehicleService.AddVehicle(Id, AddRequest);
        return Ok(result);
    }

    [HttpDelete("{id}", Name = "DeleteVehicle")]
    public ActionResult DeleteVehicle(Guid id)
    {
        throw new NotImplementedException();
    }
}
