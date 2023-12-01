using DataRepo.Models;

namespace DataRepo.Interfaces;

public interface IFuelLogRepository
{
    List<FuelLogData> GetAll();

    FuelLogData GetById(Guid id);

    List<FuelLogData> GetByVehicleId(Guid vehicleId);

    Guid Add(FuelLogData data);

    void Update(FuelLogData entity);

    void Delete(Guid id);




}
