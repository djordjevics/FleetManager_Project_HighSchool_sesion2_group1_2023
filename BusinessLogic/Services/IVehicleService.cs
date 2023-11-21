using FleetManager.Models;
using System.Xml.Linq;

namespace BusinessLogic.Services;

public interface IVehicleService
{
    List<Vehicle> Get();
    void Update(Guid id, PutVehicle updateRequest);
    void AddVehicle(Guid Id, AddVehicle AddRequest);
    void DeleteVehicle(Guid id);
}
