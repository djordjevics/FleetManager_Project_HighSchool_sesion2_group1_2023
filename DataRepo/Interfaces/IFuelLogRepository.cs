using DataRepo.Models;

namespace DataRepo.Interfaces;

public interface IFuelLogRepository
{
    List<FuelLogData> GetAll();

    FuelLogData GetById(Guid id);

    List<FuelLogData> GetByVehicleId(Guid vehicleId);

    void Update(FuelLogData entity);

    void Delete(Guid id);

}
