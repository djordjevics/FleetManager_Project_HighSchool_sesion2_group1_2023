using DataRepo.Models;

namespace DataRepo.Interfaces;

public interface IVehicleRepository
{
    List<VehicleData> Get();
    void Update(VehicleData updateRequest);
    Guid AddVehicle(VehicleData AddRequest);
    void DeleteVehicle(Guid id);
}
