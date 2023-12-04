using DataRepo.Interfaces;
using DataRepo.Models;

namespace DataRepo.Implementation
{
    public class VehicleRepository : IVehicleRepository
    {
        FleetDbContext context;

        public VehicleRepository(FleetDbContext context)
        {
            this.context = context;
        }

        public Guid AddVehicle(VehicleData AddRequest)
        {
            AddRequest.Id = Guid.NewGuid();
            context.vehicleData.Add(AddRequest);
            context.SaveChanges();
            return AddRequest.Id;
        }

        public void DeleteVehicle(Guid id)
        {
            context.Remove(id);
        }

        public List<VehicleData> Get()
        {
            return context.vehicleData.ToList();
        }

        public void Update(VehicleData updateRequest)
        {
            var upd = context.vehicleData.Find(updateRequest.Id);
            if (upd == null)
            {
                context.vehicleData.Add(updateRequest);
            }
            else
            {
                upd.FuelType = updateRequest.FuelType;
                upd.FuelCapacity = updateRequest.FuelCapacity;
                upd.FuelUnit = updateRequest.FuelUnit;
                upd.License = updateRequest.License;
            }
            context.SaveChanges();
        }
    }
}
