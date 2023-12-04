using DataRepo.Implementation;
using DataRepo.Interfaces;
using DataRepo.Models;
using FleetManager.Models;

namespace BusinessLogic.Services;

public class FuelLogService : IFuelLogService
{
    private IFuelLogRepository _repo;
    public FuelLogService(FleetDbContext context)
    {
        _repo = new FuelLogRepository(context);
    }
    public FuelLog Add(FuelLog fuelLog)
    {
        throw new NotImplementedException();
    }

    public void Delete(Guid id)
    {
        List<FuelLog> fuelLog = new List<FuelLog>(){
            new FuelLog() {
                Id = Guid.NewGuid()
            },
            new FuelLog(){
                Id = Guid.NewGuid()
            }
        };
        fuelLog.Remove(GetById(id));
    }

    public List<FuelLog> GetAllFuelLogs()
    {
        throw new NotImplementedException();
    }

    public FuelLog GetById(Guid Id)
    {
        throw new NotImplementedException();
    }

    public List<FuelLog> GetLogsByCarId()
    {
        throw new NotImplementedException();
    }

    public void Update(FuelLog fuelLog)
    {
        var data = new FuelLogData
        {
            Id = fuelLog.Id,
            FuelAdded = fuelLog.FuelAdded,
            FuelUnit = fuelLog.FuelUnit,
            Currency = fuelLog.Currency,
            Price = fuelLog.Price,
            VehicleId = fuelLog.VehicleId
        };

        _repo.Update(data);
    }
}
