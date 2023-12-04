using BusinessLogic.Services;
using DataRepo.Models;
using FleetManager.Models;
using Microsoft.AspNetCore.Mvc;

namespace FleetManager.Controllers;

[ApiController]
[Route("[controller]")]
public class VehicleController : ControllerBase
{
    private readonly ILogger<VehicleController> _logger;
    private IVehicleService _service;

    public VehicleController(ILogger<VehicleController> logger, IVehicleService service)
    {
        _logger = logger;
        _service = service;
    }

    [HttpGet(Name = "GetAllVehicles")]
    public ActionResult Get()
    {
        return Ok(_service.Get());
    }

    [HttpPut("{id}",Name ="UpdateVehicle")]
    public void Update(Guid id, PutVehicle updateRequest)
    {
        updateRequest.Id = id;
        _service.Update(id, updateRequest);
    }

    [HttpPost(Name = "AddVehicle")]
    public ActionResult AddVehicle(Guid Id,AddVehicle AddRequest)
    {
        AddRequest.Id = Id;
        _service.AddVehicle(Id, AddRequest);
        return Ok();
    }

    [HttpDelete("{id}", Name = "DeleteVehicle")]
    public ActionResult DeleteVehicle(Guid id)
    {
        throw new NotImplementedException();
    }
}
