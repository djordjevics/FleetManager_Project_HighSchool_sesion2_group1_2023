using FleetManager.Models;
using System.Xml.Linq;

namespace BusinessLogic.Services;

public interface IVehicleService
{
    List<Vehicle> Get();
    Vehicle Update(Guid id, PutVehicle updateRequest);
    Vehicle AddVehicle(Guid Id, AddVehicle AddRequest);
    void DeleteVehicle(Guid id);
}
