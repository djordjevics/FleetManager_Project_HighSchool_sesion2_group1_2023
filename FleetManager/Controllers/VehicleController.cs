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
        _vehicleService = new VehicleService();
    }

    [HttpGet(Name = "GetAllVehicles")]
    public ActionResult Get()
    {
        return Ok(_vehicleService.Get());
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
        throw new NotImplementedException();
    }

    [HttpDelete("{id}", Name = "DeleteVehicle")]
    public ActionResult DeleteVehicle(Guid id)
    {
        throw new NotImplementedException();
    }
}
