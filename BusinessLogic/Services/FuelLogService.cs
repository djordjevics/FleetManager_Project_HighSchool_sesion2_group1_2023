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
        _repo.Delete(id);
    }

    public List<FuelLog> GetAllFuelLogs()
    {
        return _repo.GetAll().Select(vd => new FuelLog()
        {
            Id = vd.Id,
            VehicleId = vd.VehicleId,
            FuelAdded = vd.FuelAdded,
            FuelUnit = vd.FuelUnit,
            Price = vd.Price,
            Currency = vd.Currency
        }).ToList();
    }

    public FuelLog GetById(Guid Id)
    {
        throw new NotImplementedException();
    }

    public List<FuelLog> GetLogsByCarId(Guid id)
    {
        return _repo.GetByVehicleId(id).Select(vd => new FuelLog()
        {
            Id = vd.Id,
            VehicleId = vd.VehicleId,
            FuelAdded = vd.FuelAdded,
            FuelUnit = vd.FuelUnit,
            Price = vd.Price,
            Currency = vd.Currency
        }).ToList();
    }
}
