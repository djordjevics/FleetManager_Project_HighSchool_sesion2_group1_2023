using FleetManager.Models;

namespace BusinessLogic.Services;

public class VehicleService : IVehicleService
{
    public Vehicle AddVehicle(Guid Id, AddVehicle AddRequest)
    {
        throw new NotImplementedException();
    }

    public void DeleteVehicle(Guid id)
    {
        throw new NotImplementedException();
    }

    public List<Vehicle> Get()
    {
        List<Vehicle> list = new List<Vehicle>(){
            new Vehicle(){
                Id = Guid.NewGuid()
            },
            new Vehicle(){
                Id = Guid.NewGuid()
            }
        };
        return list;
    }

    public Vehicle Update(Guid id, PutVehicle updateRequest)
    {
        throw new NotImplementedException();
    }
}
