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
        var data= _repo.GetById(Id);
        if (data is null)
            return null;

        return new FuelLog {
            Currency = data.Currency,
            Price = data.Price,
            FuelUnit = data.FuelUnit,
            FuelAdded = data.FuelAdded,
            Id = data.Id,
            VehicleId=data.VehicleId
        };
    }

    public List<FuelLog> GetLogsByCarId()
    {
        throw new NotImplementedException();
    }
}
