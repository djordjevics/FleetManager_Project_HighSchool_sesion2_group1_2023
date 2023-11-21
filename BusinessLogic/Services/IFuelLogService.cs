using FleetManager.Models;

namespace BusinessLogic.Services;

public interface IFuelLogService
{
    void GetAllFuelLogs();
    void GetById(Guid Id);
    void Get();
    void Post(FuelLog fuelLog);
    void Delete(Guid id);

}
