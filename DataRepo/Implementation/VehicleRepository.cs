using DataRepo.Interfaces;
using DataRepo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return AddRequest.Id;
        }

        public void DeleteVehicle(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<VehicleData> Get()
        {
            return context.vehicleData.ToList();
        }

        public void Update(VehicleData updateRequest)
        {
            throw new NotImplementedException();
        }
    }
}
