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
        throw new NotImplementedException();
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
}
