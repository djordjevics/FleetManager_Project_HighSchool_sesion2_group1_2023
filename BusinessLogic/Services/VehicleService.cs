using DataRepo.Implementation;
using DataRepo.Interfaces;
using DataRepo.Models;
using FleetManager.Models;


namespace BusinessLogic.Services;

public class VehicleService : IVehicleService
{
    private IVehicleRepository _repo;
    public VehicleService(IVehicleRepository repo)
    {
        _repo = repo;
    }
    public Vehicle AddVehicle(Guid Id, AddVehicle AddRequest)
    {
        AddRequest.Id = Id;
        var v = new VehicleData
        {
            Id = Id,
            FuelCapacity = AddRequest.FuelCapacity,
            FuelType = AddRequest.FuelType,
            FuelUnit = AddRequest.FuelUnit,
            License = AddRequest.License,
            Manufacturer = AddRequest.Manufacturer,
            Model = AddRequest.Model,
        };
        _repo.AddVehicle(v);
        return new Vehicle();
    }

    public void DeleteVehicle(Guid id)
    {
        throw new NotImplementedException();
    }

    public List<Vehicle> Get()
    {
        return _repo.Get().Select(vd => new Vehicle() { 
            Id = vd.Id,
            FuelCapacity = vd.FuelCapacity,
            FuelType = vd.FuelType,
            Manufacturer = vd.Manufacturer,
            Model = vd.Model,
            FuelUnit = vd.FuelUnit,
            License = vd.License
        }).ToList();

    }

    public Vehicle Update(Guid id, PutVehicle updateRequest)
    {
        throw new NotImplementedException();
    }
}
